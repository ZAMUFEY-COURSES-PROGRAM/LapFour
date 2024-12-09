using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Add Your Own Method
            //ChangesLabelText();
        }

        //Methods
        //access modifiers ( public [ access all projects ( Namespace ), private , protected + return type ( void [ doesnt return value ] , data type ) + MethodName + ( ... )
        public void ChangesLabelText () //Parameters / agurment / var
        {
            lblMethod.Text = "The Text Changed";
            lblMethod.ForeColor = Color.BlueViolet;
        }

        private void btnOperators_Click(object sender, EventArgs e)
        {
            //Operators

            //1. Arthemtic Operators

            //Create Var
            int Num1, Num2;

            //Instize the Vars
            Num1 = 10;
            Num2 = 20;

            //Create another Var to store The Result
            int Add, Subs, Multi, Div;

            //Proccess ( ADD SUBS MULTI DIV )
            Add = Num1 + Num2;
            Subs = Num2 - Num1;
            Multi = Num2 * Num1;
            Div = Num1 / Num2;


            //Showing the Result
            MessageBox.Show("Addition of Num1 and Num 2 " + Add);
            MessageBox.Show("Substraction of Num1 and Num2 " + Subs);
            MessageBox.Show("Mutliplication of Num1 and Num2 " +  Multi);
            MessageBox.Show("Division of Num1 and Num2 " + Div);


            //2. Comparision

            //Creating Var
            bool Cond1, Cond2;
            int Int1, Int2;

            //Instizate Var
            Cond1 = true;
            Cond2 = false;
            Int1 = 0;
            Int2 = 1;

            //Proccess ( Coditions [ Equal to , Not Equal to , Greater Than , Less Than ] )

            //Create Outcome Condition
            bool Result;

            //1. Equal To: ( == )
            Result = Cond1 == Cond2;
            MessageBox.Show("Result Outcome " + Result);

            //2. Not Equal to: ( ! ) ( = )
            Result = Cond1 != Cond2;
            MessageBox.Show("Result Outcome " + Result);

            //3. Greater Than: ( > )
            Result = Int1 > Int2;
            MessageBox.Show("Result Outcome " + Result);

            //4. Less Than: ( < )
            Result = Int1 < Int2;
            MessageBox.Show("Result Outcome " + Result);


            //3. Logical Operators

            //Create var
            bool St1, St2;
            bool ot;

            //Instizale var
            St1 = true;
            St2 = false;


            //Proccess (  Logical [ AND , OR , NOT ] )
            //1. AND ( && )
            ot = St1 && St2;
            MessageBox.Show("Result Outcome " + ot);

            //2. OR ( || )
            ot = St1 || St2;
            MessageBox.Show("Result Outcome " + ot);

            //3. NOT ( != )
            ot = St1 != St2;
            MessageBox.Show("Result Outcome " + ot);


            //4. Assgnement Operator ( = ) ( == )
            // Var + ( = ) + value

        }

        private void btnActMeth_Click(object sender, EventArgs e)
        {
            //Active marka click event Start ( Bilamato )
            ChangesLabelText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add Your Own Method
            ChangesLabelText();
        }
    }
}
