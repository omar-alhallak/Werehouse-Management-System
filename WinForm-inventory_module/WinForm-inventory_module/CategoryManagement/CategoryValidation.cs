using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinForm_inventory_module.CategoryManagement
{
    public static class CategoryValidation
    {
        private static readonly Regex NameRegex =
            new Regex(@"^[A-Za-z0-9 _-]{2,30}$");

        public static void ValidateForAdd(string name, List<Category> categories)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new CategoryException("Category name is required.");

            name = name.Trim();

            if (!NameRegex.IsMatch(name))
                throw new CategoryException("Invalid category name.");

            foreach (var c in categories)
            {
                if (string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase))
                    throw new CategoryException("Category already exists.");
            }
        }

        public static void ValidateForUpdate(int id, string name, List<Category> categories)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new CategoryException("Category name is required.");

            name = name.Trim();

            if (!NameRegex.IsMatch(name))
                throw new CategoryException("Invalid category name.");

            foreach (var c in categories)
            {
                if (c.Id != id &&
                    string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase))
                    throw new CategoryException("Category already exists.");
            }
        }
    }
}
