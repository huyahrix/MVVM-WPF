using System;
using System.Reflection;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using Model;
using System.Windows.Input;
using System.Linq.Expressions;
using System.Windows.Controls;
namespace ViewModel.Module
{
    public class AccountVM
    {
        private ObservableCollection<Account> _acountVMProperty;
        public ObservableCollection<Account> AccountVMProperty
        {
            get { return this._acountVMProperty; }
            set { _acountVMProperty = value ;}
        }
        public AccountVM()
        {
            //ObservableCollection < T > has a constructor overload which takes IEnumerable < T >
            // _acountVMProperty = new DBDataContext().Accounts.ToList();
            // _acountVMProperty = new DBDataContext().Accounts.ToList();
            AccountVMProperty = new ObservableCollection<Account >(new DBDataContext().Accounts .ToList ());
        }
    }
}
