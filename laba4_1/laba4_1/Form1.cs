using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*События KeyDown и KeyUp отправляются сфокусированному контролу. Если на форме есть другие контролы, и они сфокусированы, то они будут заглатывать эти события, и форме ничего не останется.
  Поэтому, чтобы форме всегда приходили эти события, нужно установить для неё KeyPreview=true.
*/

namespace laba4_1
{
    public partial class Form1 : Form
    {
        private int radius = 0;
        private List<CCircle> Circles = new List<CCircle>();
        private int ctrl = 0;

        public Form1()
        {
            InitializeComponent();
            radius = 25;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (CCircle Circle in Circles) // foreach перечисляет элементы коллекции и выполняет тело для каждого её элемента
            {
                Circle.drawCircle(e.Graphics);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (ctrl == 0)
            {
                foreach (CCircle Circle1 in Circles)
                {
                    Circle1.setColor("Gray"); //Снятие выделения со всех объектов 
                }
                CCircle Circle = new CCircle(e.X, e.Y, radius);
                Circles.Add(Circle);
            }
            if (ctrl == 1)
            {
                foreach (CCircle Circle1 in Circles)
                {
                    if (Circle1.mouseinCircle(e) == true)
                    {
                        checkBoxCrcl.Checked = true;
                        break;
                    }
                }
                Refresh(); // Refresh принудительно создает условия, при которых элемент управления делает недоступной свою клиентскую область и немедленно перерисовывает себя и все дочерние элементы
            }
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                checkBoxCtrl.Checked =! checkBoxCtrl.Checked;
            }
            switch (ctrl)
            {
                case 0:
                    ctrl++;
                    foreach (CCircle Circle1 in Circles)
                    {
                        Circle1.setCtrl(true);
                    }
                    break;
                case 1:
                    ctrl = 0;
                    foreach (CCircle Circle1 in Circles)
                    {
                        Circle1.setCtrl(false);
                    }
                    break;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Circles.Count(); i++)
            {
                if (Circles[i].getColor() == "Green")
                {
                    Circles.RemoveAt(i); // удаление элемента списка
                    i--;
                    checkBoxCrcl.Checked = false;
                }
            }
            Refresh();
        }

        public class CCircle
        {
            private int coordX, coordY, radius;
            private string color = "Green";
            private bool ctrl = false;
            public CCircle(int coordX, int coordY, int radius)
            {
                this.coordX = coordX;
                this.coordY = coordY;
                this.radius = radius;

            }
            public void drawCircle(Graphics Canvas)
            {
                if (color == "Green")
                {
                    Canvas.DrawEllipse(new Pen(Color.Green, radius * 2),  //Структура Pen, определяющая цвет, ширину и стиль эллипса.
                                                       coordX - radius,   //Координата X верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.
                                                       coordY - radius,   //Координата Y верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.
                                                       radius * 2,        //Ширина ограничивающего прямоугольника, который определяет эллипс.
                                                       radius * 2);       //Высота ограничивающего прямоугольника, который определяет эллипс.
                }
                else
                {
                    Canvas.DrawEllipse(new Pen(Color.Gray, radius * 2),
                                                       coordX - radius,
                                                       coordY - radius,
                                                       radius * 2,
                                                       radius * 2);
                }
            }
            public void setColor(string Color)
            {
                color = Color;
            }
            public string getColor()
            {
                return color;
            }
            public bool mouseinCircle(MouseEventArgs e)
            {
                if (ctrl)
                {
                    if (Math.Pow(e.X - coordX, 2) + Math.Pow(e.Y - coordY, 2) <= Math.Pow(radius, 2) && color != "Green")
                    {
                        color = "Green";
                        return true;
                    }
                }
                return false;
            }
            public void setCtrl(bool a)
            {
                ctrl = a;
            }

        }
    }
}