using Masrwof.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masrwof.Interfaces
{
    public interface IExpenseService
    {
        Expense GetExpenseById(Guid id);
        void UpdateExpense(Expense expense);
        List<Expense> GetAllExpenses();
        void addExpense(Expense expense);
        void DeleteExpense(Guid id);
        decimal getTotalExpenses();
    }
}
