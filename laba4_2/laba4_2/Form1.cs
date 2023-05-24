using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using laba4_2.Properties;

// Данные, которые хранятся, логика, которая обрабатывает эти данные и их визуальное отображение должны быть разделены (храним все в разных местах)

namespace laba4_2
{
    public partial class Form1 : Form
    {
        Model model; //Ссылка на Model        

        public Form1()
        {
            InitializeComponent();
            model = new Model(); //Форма создает модель
            model.observer += new EventHandler(this.UpdateFromModel); //Форма подписывается на обновление модели
                                                                      //При обновлении формы вызывается метод UodateFromModel
        }

        private void textBoxA_Leave(object sender, EventArgs e)
        {
            try // Для перехвата и обработки исключений
            {
                model.set_A_Value(Int32.Parse(textBoxA.Text)); //Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком
            }
            catch (Exception) { }
        }

        private void textBoxB_Leave(object sender, EventArgs e)
        {
            try
            {
                model.set_B_Value(Int32.Parse(textBoxB.Text));
            }
            catch (Exception) { } //Exception - базовый для всех типов исключений
        }

        private void textBoxC_Leave(object sender, EventArgs e)
        {
            try
            {
                model.set_C_Value(Int32.Parse(textBoxC.Text));
            }
            catch (Exception) { }
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            model.set_A_Value(Decimal.ToInt32(numericUpDownA.Value)); //Decimal представляет десятичное число с плавающей запятой
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            model.set_B_Value(Decimal.ToInt32(numericUpDownB.Value));
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            model.set_C_Value(Decimal.ToInt32(numericUpDownC.Value));
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            model.set_A_Value(trackBarA.Value);
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            model.set_B_Value(trackBarB.Value);
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            model.set_C_Value(trackBarC.Value);
        }
        private void UpdateFromModel(object sender, EventArgs e)
        {
            //Когда модель обновляется, компоненты, отображаемые на форме, все разом получают обновлённое значение  
             
            textBoxA.Text = model.get_A_Value().ToString();
            textBoxB.Text = model.get_B_Value().ToString();
            textBoxC.Text = model.get_C_Value().ToString();

            numericUpDownA.Value = model.get_A_Value();
            numericUpDownB.Value = model.get_B_Value();
            numericUpDownC.Value = model.get_C_Value();

            trackBarA.Value = model.get_A_Value();
            trackBarB.Value = model.get_B_Value();
            trackBarC.Value = model.get_C_Value();
        }        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {            
            model.saveValues();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            model.loadValues();
        }


        public class Model
        {
            private int valueA, valueB, valueC; //Место, где хранятся наши значения
            public System.EventHandler observer;

            //Описание всех бизнес-правил, которые позволяют менять значения одним образом и не позволяют другим
            
            public void set_A_Value(int value)
            {
                observer.Invoke(this, EventArgs.Empty);
                if (value < 0) return;
                if (value > 100) return;
                if (value > valueB) set_B_Value(value);
                if (value > valueC) set_C_Value(value);
                valueA = value;
                observer.Invoke(this, null);
            }

            public void set_B_Value(int value)
            {
                observer.Invoke(this, EventArgs.Empty);
                if (value < 0) return;
                if (value > 100) return;
                if (value < valueA) return;
                if (value > valueC) return;
                valueB = value;
                observer.Invoke(this, null); //Модель будет уведомлять всех тех, кто на нее подписался
            }

            public void set_C_Value(int value)
            {
                observer.Invoke(this, EventArgs.Empty);
                if (value < 0) return;
                if (value > 100) return;
                if (value < valueA) set_A_Value(value);
                if (value < valueB) set_B_Value(value);
                valueC = value;
                observer.Invoke(this, null);
            }

            public int get_A_Value()
            {
                return valueA;
            }
            public int get_B_Value()
            {
                return valueB;
            }
            public int get_C_Value()
            {
                return valueC;
            }
            public void saveValues()
            {
                Properties.Settings.Default.dataA = valueA;
                Properties.Settings.Default.dataB = valueB;
                Properties.Settings.Default.dataC = valueC;
                Properties.Settings.Default.Save();
            }
            public void loadValues()
            {
                valueA = Properties.Settings.Default.dataA;
                valueB = Properties.Settings.Default.dataB;
                valueC = Properties.Settings.Default.dataC;
                observer.Invoke(this, null);
            }
        }        
    }
}