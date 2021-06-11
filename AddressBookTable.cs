using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookService_LINQ_And_DataTable
{
    class AddressBookTable
    {
        public void CreateAddressBookDataTable()
        {
            DataTable addressBookTable = new DataTable();
            addressBookTable.Columns.Add("FirstName", typeof(string));
            addressBookTable.Columns.Add("LastName", typeof(string));
            addressBookTable.Columns.Add("Address", typeof(string));
            addressBookTable.Columns.Add("City", typeof(string));
            addressBookTable.Columns.Add("State", typeof(string));
            addressBookTable.Columns.Add("Zip", typeof(int));
            addressBookTable.Columns.Add("PhoneNumber", typeof(long));
            addressBookTable.Columns.Add("Email", typeof(string));
        }
    }
}
