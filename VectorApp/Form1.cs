using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);

            e.Graphics.DrawLine(pen, 282.5f, 0, 282.5f, 506);

            e.Graphics.DrawLine(pen, 0, 253, 565, 253);

            for (int x = 0; x < 45; x++)
            {
                e.Graphics.FillEllipse(pen.Brush, new RectangleF(x * 15 + 1.5f, 250, 6, 6));
            }

            for (int y = 0; y < 45; y++)
            {
                e.Graphics.FillEllipse(pen.Brush, new RectangleF(279, y * 15 + 1.5f, 6, 6));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case (int)calculation.Magnitude:
                    calculateMagnitude();
                    break;
                case (int)calculation.Direction:
                    calculateDirection();
                    break;
                case (int)calculation.Add:
                    calculateAddition();
                    break;
                case (int)calculation.Negation:
                    calculateNegation();
                    break;
                case (int)calculation.Subtraction:
                    calculateSubtraction();
                    break;
                case (int)calculation.Scaling:
                    calculateScaling();
                    break;
                case (int)calculation.Normalization:
                    calculateNormalization();
                    break;
                case (int)calculation.Dot:
                    calculateDotProduct();
                    break;
                case (int)calculation.Cross:
                    calculateCrossProduct();
                    break;
                case (int)calculation.AngleBetween:
                    calculateAngleBetween();
                    break;
                case (int)calculation.Projection:
                    calculateProjection();
                    break;
                default:
                    break;
            }
            

        }
        
        private void calculateMagnitude()
        {
            Vector2 vecA = new Vector2(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            label8.Text = "Answer: " + vecA.magnitude();
        }
        private void calculateDirection()
        {
            Vector2 vecA = new Vector2(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            Vector2 vecB = new Vector2(float.Parse(textBox4.Text), float.Parse(textBox3.Text));

            label8.Text = "Answer: " + vecA.direction() + "°";

        }
        private void calculateAddition()
        {
            Vector2 vecA = new Vector2(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            Vector2 vecB = new Vector2(float.Parse(textBox4.Text), float.Parse(textBox3.Text));
            label8.Text = "Answer: " + (vecA + vecB).print();
        }
        private void calculateNegation()
        {
            Vector2 vecA = new Vector2(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            Vector2 vecB = new Vector2(float.Parse(textBox4.Text), float.Parse(textBox3.Text));
            label8.Text = "Answer: " + vecA.negate().print();
        }
        private void calculateSubtraction()
        {
            Vector2 vecA = new Vector2(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            Vector2 vecB = new Vector2(float.Parse(textBox4.Text), float.Parse(textBox3.Text));
            label8.Text = "Answer: " + (vecA - vecB).print();
        }
        private void calculateScaling()
        {
            Vector2 vecA = new Vector2(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            Vector2 vecB = new Vector2(float.Parse(textBox4.Text), float.Parse(textBox3.Text));
            label8.Text = "Answer: " + (vecA * vecB).print();
            
        }
        private void calculateNormalization()
        {
            Vector2 vecA = new Vector2(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            Vector2 vecB = new Vector2(float.Parse(textBox4.Text), float.Parse(textBox3.Text));
            label8.Text = "Answer: " + vecA.normalize().print();

        }
        private void calculateDotProduct()
        {
            Vector2 vecA = new Vector2(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            Vector2 vecB = new Vector2(float.Parse(textBox4.Text), float.Parse(textBox3.Text));
            label8.Text = "Answer: " + vecA.dot(vecB);
        }
        private void calculateCrossProduct()
        {
            Vector2 vecA = new Vector2(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            Vector2 vecB = new Vector2(float.Parse(textBox4.Text), float.Parse(textBox3.Text));
            label8.Text = "Answer: " + vecA.cross(vecB);
        }
        private void calculateAngleBetween()
        {
            Vector2 vecA = new Vector2(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            Vector2 vecB = new Vector2(float.Parse(textBox4.Text), float.Parse(textBox3.Text));

            label8.Text = "Answer: " + vecA.angleBetween(vecB) + "°";

        }
        private void calculateProjection()
        {
            Vector2 vecA = new Vector2(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
            Vector2 vecB = new Vector2(float.Parse(textBox4.Text), float.Parse(textBox3.Text));
            label8.Text = "Answer: " + vecA.projection(vecB).print();

        }


        private enum calculation
        {
            Magnitude, Direction, Add, Negation, Subtraction, Scaling, Normalization, Dot, Cross, AngleBetween, Projection
        }

    }
}
