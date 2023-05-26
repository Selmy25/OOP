﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP7
{
    public partial class Form : System.Windows.Forms.Form
    {
        Storage myStorage = new Storage();
        bool controlUp = false;
        Color btn_color = Color.Black;
        bool circle = true;
        bool square = false;
        bool triangle = false;

        public Form()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < myStorage.getSize(); i++)
            {
                myStorage.getObject(i).OnPaint(e);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
            if (circle)
                myStorage.AddObject(new CCircle(e.Location, btn_color, picturbx), e, controlUp);

            if (square)
                myStorage.AddObject(new CSquare(e.Location, btn_color, picturbx), e, controlUp);

            if (triangle)
                myStorage.AddObject(new Triangle(e.Location, btn_color, picturbx), e, controlUp);
            picturbx.Invalidate();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Add) //Увеличение
                for (int i = 0; i < myStorage.getSize(); i++)
                {
                    if (myStorage.getObject(i).getselection() == true)
                        myStorage.getObject(i).increase_Size();
                }

            if (e.KeyData == Keys.Subtract)//Уменьшение
                for (int i = 0; i < myStorage.getSize(); i++)
                {
                    if (myStorage.getObject(i).getselection() == true)
                        myStorage.getObject(i).decrease_Size();
                }

            if (e.Control) //Выбор объектов
                controlUp = true;

            if (e.KeyData == Keys.Delete)//Удаление объектов
                myStorage.delete_selectedObjects();


            //обработка 4 кнопок движения

            if (e.KeyData == Keys.Right)//Движение вправо
            {
                for (int i = 0; i < myStorage.getSize(); i++)
                {
                    if (myStorage.getObject(i).getselection())
                        myStorage.getObject(i).move_Object(6, 0);
                }
            }
            if (e.KeyData == Keys.Left)//Движение влево
            {
                for (int i = 0; i < myStorage.getSize(); i++)
                {
                    if (myStorage.getObject(i).getselection())
                        myStorage.getObject(i).move_Object(-6, 0);
                }
            }
            if (e.KeyData == Keys.Down)//тут +1, ибо ось Y направлена вниз
            {
                for (int i = 0; i < myStorage.getSize(); i++)
                {
                    if (myStorage.getObject(i).getselection())
                        myStorage.getObject(i).move_Object(0, 6);
                }
            }
            if (e.KeyData == Keys.Up)//тут -1, ибо ось Y направлена вниз
            {
                for (int i = 0; i < myStorage.getSize(); i++)
                {
                    if (myStorage.getObject(i).getselection())
                        myStorage.getObject(i).move_Object(0, -6);
                }
            }
            if (e.Shift )
                myStorage.GroupObjects();
            if (e.KeyData == Keys.A)
                myStorage.UngroupObjects();

            picturbx.Invalidate();
        }

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            controlUp = false;
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            btn_color = ((Button)sender).BackColor;
            for (int i = 0; i < myStorage.getSize(); i++)
            {
                if (myStorage.getObject(i).getselection())
                    myStorage.getObject(i).object_color = btn_color;
            }
            picturbx.Invalidate();
            this.ActiveControl = null;
        }

        private void btn_crcle_Click(object sender, EventArgs e)
        {
            circle = true;
            square = false;
            triangle = false;
            btn_crcle.BackColor = Color.White;
            btn_sqr.BackColor = Color.DimGray;
            btn_tri.BackColor = Color.DimGray;
        }

        private void btn_sqr_Click(object sender, EventArgs e)
        {
            circle = false;
            square = true;
            triangle = false;
            btn_crcle.BackColor = Color.DimGray;
            btn_sqr.BackColor = Color.White;
            btn_tri.BackColor = Color.DimGray;
        }

        private void btn_tri_Click(object sender, EventArgs e)
        {
            circle = false;
            square = false;
            triangle = true;
            btn_crcle.BackColor = Color.DimGray;
            btn_sqr.BackColor = Color.DimGray;
            btn_tri.BackColor = Color.White;
        }

        private void btn_manycolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btn_color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;

                for (int i = 0; i < myStorage.getSize(); i++)    //изменяем цвет у всех выбранных объектов
                {
                    if (myStorage.getObject(i).getselection())
                        myStorage.getObject(i).object_color = btn_color;
                }
                picturbx.Invalidate();
            }
            this.ActiveControl = null;
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myStorage.getSize(); i++)
            {
                myStorage.delete_all();
            }
            picturbx.Invalidate();
            this.ActiveControl = null;
        }

        private void picturbx_Resize(object sender, EventArgs e)
        {
            for (int i = myStorage.getSize() - 1; i >= 0; i--)
            {
                myStorage.getObject(i).SetBord(picturbx.Width,picturbx.Height);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = picturbx;
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\Users\neket\Desktop\projects\visual\OOP7";
            sfd.Filter = "TXT files|*.txt";
            if (sfd.ShowDialog() == DialogResult.Cancel) return;
            string filename = sfd.FileName;
            myStorage.SaveStorage(filename);
            this.ActiveControl = picturbx;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT files|*.txt";
            ofd.InitialDirectory = @"C:\Users\neket\Desktop\projects\visual\OOP7";
            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            string path = ofd.FileName;
            myStorage.delete_all();
            MyObjectsFactory factory = new MyObjectsFactory();
            myStorage.LoadStorage(factory, path);
            picturbx.Invalidate();
            this.ActiveControl = picturbx;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
