using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Burger// public/internal/protected/private
    {
        private string cabbage;

        public static int disc = 0;

        public string Sause { get; set; }

        public string Name { get; set; }

        public string Cabbage
        {
            get { return cabbage; }
            set { cabbage = value; }
        }

        public string Cutlet { get; set; }

        public string Bread { get; set; }

        public int CountOfCutlets { get; set; }

        public bool IsHot { get; set; }

        public double Cost { get; set; }


        public Burger(string  sause, string cutlet)// инициализация объектов
        {
            this.Sause = sause;
            this.Cutlet= cutlet;
        }

        public Burger(string cutlet, int countOfCutlet, string cabbage)// инициализация объектов
        {
            this.Cutlet= cutlet;
            this.CountOfCutlets = countOfCutlet;
        }

        /// <summary>
        /// Рассчет стоимости вместе со скидкой
        /// </summary>
        /// <param name="bonus"></param>
        /// <returns></returns>
        public double CalculateCostWithBonus(int bonus)// в %, например 10% скидки, СИГНАТУРА МЕТОДА    
        {
            double newCost = Cost - (Cost * bonus / 100);
            return newCost;
        }

        /// <summary>
        /// Формируем состав бургера
        /// </summary>
        /// <returns></returns>
        public string GetContent () => 
            $"Состав супер крутого бургера: \n " +
            $"Котлета: {Cutlet} \n " +
            $"Количество котлет: {CountOfCutlets}\n " +
            $"Соус: {Sause} \n" +
            $"Капуста: {Cabbage} \n" +
            $"Булочки: {Bread} \n" +
            $"Подогрев: {IsHot} \n" +
            $"Стоимость: {Cost}";


        /// <summary>
        /// Формируем состав бургера с комментарием от клиента
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        public string GetContent(string comment) => 
            $"Состав супер крутого бургера: \n " +
            $"Котлета: {Cutlet} \n " +
            $"Количество котлет: {CountOfCutlets}\n " +
            $"Соус: {Sause} \n" +
            $"Капуста: {Cabbage} \n" +
            $"Булочки: {Bread} \n" +
            $"Подогрев: {IsHot} \n" +
            $"Стоимость: {Cost} \n" +
            $"Комментарий: {comment}";
    }

}
