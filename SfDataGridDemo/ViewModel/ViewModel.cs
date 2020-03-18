using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel
    {
        private ObservableCollection<OrderInfo> _orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public ViewModel()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI",25000));
            _orders.Add(new OrderInfo(1002, "Ana Trujilo", "Mexico", "ANATR",36000));
            _orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico", "ANTON",40040));
            _orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT",10700));
            _orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden", "BERGS", 20300));
            _orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", 50700));
            _orders.Add(new OrderInfo(1007, "Frederique Citeaux", "France", "BLONP", 80100));
            _orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain", "BOLID", 35000));
            _orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France", "BONAP", 20030));
            _orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "Canada", "BOTTM", 54000));
            _orders.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI",  22000));
            _orders.Add(new OrderInfo(1001, "Ana Trujilo", "Mexico", "ANATR", 30050));
            _orders.Add(new OrderInfo(1001, "Antonio Moreno", "Mexico", "ANTON",  40800));
            _orders.Add(new OrderInfo(1002, "Thomas Hardy", "UK", "AROUT",  10020));
            _orders.Add(new OrderInfo(1003, "Christina Berglund", "Sweden", "BERGS", 20050));
            _orders.Add(new OrderInfo(1003, "Hanna Moos", "Germany", "BLAUS",  50080));
            _orders.Add(new OrderInfo(1004, "Frederique Citeaux", "France", "BLONP",  89000));
            _orders.Add(new OrderInfo(1006, "Martin Sommer", "Spain", "BOLID",  30400));
            _orders.Add(new OrderInfo(1005, "Laurence Lebihan", "France", "BONAP",  20100));
            _orders.Add(new OrderInfo(1005, "Elizabeth Lincoln", "Canada", "BOTTM", 50060));
        }
    }
}
            
        
     

