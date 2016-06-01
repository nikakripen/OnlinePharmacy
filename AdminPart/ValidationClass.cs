using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Filters;
using Repository.Models;
using Repository.Repository;


namespace AdminPart
{
    static public class ValidationClass
    {
        public static bool ValidateNullBox(string field, string name)
        {
            if (field == "")
            {
                throw new Exception("Поле " + name + " должно быть заполнено!");
            }
            return true;
        }

        public static bool ValidateLengthBox(string field, string name, int min, int max)
        {
            if (field.Length < min || field.Length > max)
            {
                throw new Exception("Поле "+ name + " должно содержать от "+ min +" до "+ max +" символов!");
            }
            return true;
        }

        public static bool ValidateRangeBox(string field, string name, double min, double max)
        {
            try
            {
                if (Convert.ToDouble(field) < min || Convert.ToDouble(field) > max)
                {
                    throw new Exception("Поле "+ name +" должно содержать значения от "+ min +" до " + max + "!");
                }
            }
            catch (FormatException)
            {
                throw new Exception("Поле "+ name +" должно содержать цифровые значения!");
            }
            return true;
        }

        public static bool IsMedicineAlreadyExist(Medicine medicine, IRepository<Medicine> repository)
        {
            if (repository.GetAll().IsMedicineExist(medicine.Name, medicine.ProductForm, medicine.Manufacturer))
            {
                throw new Exception("Такое лек.средство уже существует в системе!");
            }
            return false;
        }

        public static bool ValidateMedicine(Medicine medicine)
        {
            ValidateNullBox(medicine.Name, "Наименование");
            ValidateNullBox(medicine.Manufacturer, "Производитель");
            ValidateNullBox(medicine.ProductForm, "Форма выпуска");
            ValidateLengthBox(medicine.Name, "Наименование", 2, 255);
            ValidateLengthBox(medicine.ProductForm, "Форма выпуска", 2, 255);
            ValidateLengthBox(medicine.Manufacturer, "Производитель", 2, 255);
            ValidateRangeBox(medicine.Price.ToString(), "Цена", 100, 100000000);
            return true;
        }


    }
}
