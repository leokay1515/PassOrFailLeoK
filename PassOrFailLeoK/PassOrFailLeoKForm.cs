using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassOrFailLeoK
{
    public partial class frmPassOrFailLeoK : Form
    {

        //input and output files
        string filepath = "DATA10.txt";
        string outputFile = "DATA10_Output";

        //variables
        float weightTests, weightAssign, weightProjects, weightQuizzes;
        float markTests, markAssign, markProjects, markquizzes;
        int numStudents;
        float average;
        int numPassed = 0;
        int counterA, counterB;

        public frmPassOrFailLeoK()
        {
            InitializeComponent();
        }

        private void btnParseFile_Click(object sender, EventArgs e)
        {
            //read each line of the file into a string array
            string[] lines = System.IO.File.ReadAllLines(filepath);

            //loop through each line in array of lines
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(outputFile))
            {
                //loop through each line in the array
                for (counterA = 0; counterA < lines.Length; counterA++)
                {
                    //initialize number of students who got > 50
                    numPassed = 0;

                    //read the first line for the next set of students
                    string line = lines[counterA];

                    //split each weight by the space
                    string[] weights = line.Split(' ');

                    //get the weights for the tests, assignments, projects and quizzes
                    weightTests = float.Parse(weights[0]);
                    weightAssign = float.Parse(weights[1]);
                    weightProjects = float.Parse(weights[2]);
                    weightQuizzes = float.Parse(weights[3]);

                    //for testing purposes, write the weights to the output file
                    file.WriteLine("weights " + weightTests + " " + weightAssign + " " + weightProjects + " " + weightQuizzes);


                }
            }
        }
    }
}
