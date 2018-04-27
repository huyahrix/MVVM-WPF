using System;
using System.Reflection;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Linq;
using Model;
using System.Windows.Input;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Controls;

namespace ViewModel
{

    //ObservableCollection<T>  inheritance InotifyPropertyChanged
    //System.Object
    //System.Collections.ObjectModel.Collection<T>
    //System.ComponentModel.BindingList<T>
    public class CustomerViewModel : UserControl// INotifyPropertyChanged
    {
        // implement
        // delegate type
        //public event PropertyChangedEventHandler PropertyChanged = delegate { };
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        //normal menthod 
        //private void RaisePropertyChanged(string PropertyName)
        //{
        //    //instance of delegate-type PropertyChanged
        //    var handlers = PropertyChanged;
        //    handlers(this,RaisePropertyChanged (PropertyName));
        //}

        private void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
        //public void OnPropertyChange<t>(Expression<func><t>> propertyExpression )
        //{
        //    OnPropertyChange(propertyExpression.Name);
        //}
        #endregion
        private List<Account> _customers;//=  new DB().Customers.ToList();
        public List<Account > Customers
        {
            //get { return _customers; }
            //set {
            //    _customers = value;
            //    OnPropertyChanged(() => this.Customers);
            //}
            //    get; set;
            get { return _customers; }
            set { SetValue(CustomersProperty, value); }
        }
        #region Dependency Properties
        public static readonly DependencyProperty CustomersProperty = DependencyProperty.Register("Customers", typeof(List<Account>), typeof(CustomerViewModel), new PropertyMetadata(default(List<Account >)));
        #endregion
        public CustomerViewModel()
        {
            // Customers; 
            _customers = new DBDataContext().Accounts .ToList();
            Customers = _customers;
            try
            {
                //delete
                DeleteCommand = new RelayCommand<object>((p) => p != null, (e) => //execute
                {
                    DBDataContext dataContext = new DBDataContext();
                    var cus = dataContext.Accounts .Single(c => c.AccountID  == e.ToString());
                    dataContext.Accounts.DeleteOnSubmit(cus);
                    dataContext.SubmitChanges();
                    Customers = new DBDataContext().Accounts .ToList();
                });
                //add
                AddCommnand = new RelayCommand<UIElementCollection>((p) => p != null, (e) => // execute
                   {
                       string ID = "";
                       string Name = "";
                       foreach (var item in e)
                       {
                           TextBox t = item as TextBox;
                           if (t == null)
                               continue;
                           switch (t.Name)
                           {
                               case "txtID":
                                   ID = t.Text;
                                   break;
                               case "txtName":
                                   Name = t.Text;
                                   break;
                           }
                       }
                       DBDataContext dataContext = new DBDataContext();
                       Account  newCus = new Account();
                       newCus.AccountID  = ID;
                       newCus.AccountNameU = Name;
                       dataContext.Accounts.InsertOnSubmit(newCus);
                       dataContext.SubmitChanges();
                       Customers = dataContext.Accounts.ToList();
                   });
                //Edit
                EditCommmand = new RelayCommand<UIElementCollection>((p) => true, (e) => // execute
                {
                    string id = "";
                    string companyName = "";
                    foreach (var item in e)
                    {
                        var t = item as TextBox;
                        if (t == null)
                            continue;
                        switch (t.Name)
                        {
                            case "txtID":
                                id = t.Text;
                                break;
                            case "txtName":
                                companyName = t.Text;
                                break;
                        }
                    }
                    if (id == null)
                        return;
                    DBDataContext db = new DBDataContext();
                    var cus = db.Accounts .Where(c => c.AccountID == id).FirstOrDefault();
                    cus.AccountNameU  = companyName;
                    db.SubmitChanges();
                    Customers = db.Accounts .ToList();
                });
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }
        // property type
        public ICommand DeleteCommand
        { get; set; }
        public ICommand AddCommnand
        { get; set; }
        public ICommand EditCommmand
        { get; set; }
    }
}