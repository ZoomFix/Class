using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class StorageModel
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Вместимость
        /// </summary>
        public double Capacity { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Тип склада
        /// </summary>
        public StorageType StorageType { get; set; }
        /// <summary>
        /// Складской журнал
        /// </summary>
        public List<Items> Items { get; set; }
    }

    public class Items
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public string Price { get; set; }
        /// <summary>
        /// Кол-во
        /// </summary>
        public int Units { get; set; }

        public override string ToString()
        {
            return $"Имя: {Name}, Цена: {Price}, Количество: {Units}";
        }
    }

    public enum StorageType
    {
        /// <summary>
        /// Топливо
        /// </summary>
        Fuel,
        /// <summary>
        /// Материалы
        /// </summary>
        Materials,
        /// <summary>
        /// Комплектующие изделия
        /// </summary>
        Components,
    }
}
