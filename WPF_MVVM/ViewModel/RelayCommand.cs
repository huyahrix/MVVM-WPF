using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    //MVVM with WPF
    //OOP Polymorphism(Relaycommand implement Icommnad(inteface))

    class RelayCommand<T>:ICommand
    {
        private readonly Predicate<T> _canExecute; //Lưu trữ điều kiện thục thi commnand
        private readonly Action<T> _execute; // lưu trữ hàm ủy thác
        //khi khởi tạo thì truyền điều kiện ủy thác  và hàm ủy thác
        //Contructor
        public RelayCommand(Predicate<T> canExecute, Action<T> execute)
        { 
            if (execute == null)
                throw new ArgumentException("execute");
            _canExecute = canExecute;
            _execute = execute;
        }
        // Điều kiện chạy command
        public bool CanExecute(Object parameter)
        {
            return _canExecute == null ? true : _canExecute((T)parameter);
        }
        //hàm ủy thác khi gọi command
        public void Execute(object parameter)
        { _execute((T)parameter);} 
        // tạo 1 Property(event) có tên tương ứng để ủy thác
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}