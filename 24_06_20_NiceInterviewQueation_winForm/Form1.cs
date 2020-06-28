using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_06_20_NiceInterviewQueation_winForm
{
    public partial class Form1 : Form
    {

        private readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Verifier _verifier = new Verifier();
        

        private string _sentence;
        private string _formula;
        private static List<string> _inputsLst;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            _inputsLst = InitializeChoosingMenu();

            cmbpreparedFormulas.Items.AddRange(InitialiseFormulas().ToArray());
            cmbPreparedSentences.Items.AddRange(_inputsLst.ToArray());

            cmbpreparedFormulas.SelectedIndexChanged += (object sender, EventArgs e) => { txtFormula.Text = (string)cmbpreparedFormulas.SelectedItem; };
            cmbPreparedSentences.SelectedIndexChanged += (object sender, EventArgs e) => { txtSentence.Text = (string)cmbPreparedSentences.SelectedItem; };
            txtSentence.TextChanged += (object sender, EventArgs e) => { _sentence = txtSentence.Text; };
            txtFormula.TextChanged += (object sender, EventArgs e) => { _sentence = txtFormula.Text; };

            _verifier.isDupplicationsAllowed = chkDuplications.Checked;
            chkDuplications.CheckedChanged += (object sender, EventArgs e) => { chkDuplications.Text = chkDuplications.Checked ? "מותר כפילויות" : "אסור כפילויות"; };

            //default formula
            txtFormula.Text = "A,B,C@D,A,E,D@F,B,O,P@Z,A";
            //default sentence
            txtSentence.Text = "B,Z,D,B";

            btnVerify.Click += (object sender, EventArgs e) =>
            {
                _verifier.isDupplicationsAllowed = chkDuplications.Checked;

                _sentence = txtSentence.Text.PrepareSentence();
                if (cmbPreparedSentences.SelectedIndex != -1)
                    _sentence = (string)cmbPreparedSentences.SelectedItem;                    
                

                _formula = txtFormula.Text;
                if(cmbpreparedFormulas.SelectedIndex != -1)
                     _formula = (string)cmbpreparedFormulas.SelectedItem;

                bool isIt = _verifier.IsAppropriateByFormula(_formula, _sentence);
                

                string explainFalse = string.Empty;
                if(!isIt && !chkDuplications.Checked && _verifier.Duplicates != null)
                {
                    explainFalse += ",\n\nbecause the input sentence contains \n";
                    foreach(var s in _verifier.Duplicates)
                    {
                        explainFalse += $"the letter {s.Key} {HowManyTimes(s.Key, _sentence)} times\n,";
                    }                    
                }

                string userMessage = $"Formula: {_formula}\n\n The choosen input sentence: {_sentence}\n\n {isIt}{explainFalse}";
                //string userMessage = $"Formula: {_formula}\n\n The choosen input sentence: {_sentence}\n\n {isIt}";

                log.Debug(userMessage);

                MessageBox.Show(userMessage);
                Statics.SideStore.Clear();
                cmbPreparedSentences.SelectedIndex = -1;
            };
            
        }

        private int HowManyTimes(char c, string sentence)
        {
            int count = 0;
            foreach (char s in sentence)
            {
                if (s.Equals(c)) count++;
            }
            return count;                           
        }

        private List<string> InitializeChoosingMenu()
        {
            List<string> menu = new List<string>();
            menu.Add("A,D,F");
            menu.Add("B,D,F");
            menu.Add("F,D,A");
            menu.Add("F,E,B");

            menu.Add("A,B,D,F");
            menu.Add("A,D");
            menu.Add("D,C,F,A");
            menu.Add("E, F");
            menu.Add("N");
            menu.Add("A,E,F");
            menu.Add("A,J,E,F");
            menu.Add("A,A,F");
            menu.Add("A,A,N,F");
            menu.Add("A,G,F");
            menu.Add("A,E,F");
            menu.Add("C,A,O");
            menu.Add("A,A,O");
            menu.Add("C,A,O,Z");
            menu.Add("A,D,F,Z");
            menu.Add("Z,F,A,D");
            menu.Add("C,A,D,B");
            menu.Add("B,Z,D,B");
            menu.Add("B,E,D,B");

            return menu;
        }

        private List<string> InitialiseFormulas()
        {
            List<string> lst = new List<string>();
            lst.Add("A,B,C@D,E@F");
            lst.Add("A,B,C@D,A,E@F");
            lst.Add("A,B,C@D,A,E,D@F,B,O,P@Z,A");            

            return lst;
        }

        
    }
}
