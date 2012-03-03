/*
 * Program to generate random groups for given tasks.
 * Written by Daniel Auhuber, FSI 1
 * 01/03/2012
 */

/*
 * TODO
 * -wenn Anzahl SChüler erniedrigt wird, bestehende Einträge anpassen.
 * -Schüler Namen anstatt Nr.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20120301_gruppenEinteilung {

    public partial class Form1 : Form {

        const int DEFAULTGRUPPEN = 2;
        int anzahlSchueler = 0;
        int gruppenGroesse = 0;
        SchuelerSelection[] mSchueler;
        string[,] mAuswahl;
        string[,] mAuswahlAufgabe1;
        string[,] mAuswahlAufgabe2;

        public Form1() {
            
            InitializeComponent();
            nudGruppen.Value = DEFAULTGRUPPEN;
        }

        public class SchuelerSelection {

            private GroupBox gbxSelection;
            private Label lblSchueler;
            private RadioButton rbtnAufgabe1;
            private RadioButton rbtnAufgabe2;
            private CheckBox cbxSolo;
            //checkbox fuer einzelgruppe

            public SchuelerSelection() {

                gbxSelection = new GroupBox();
                lblSchueler = new Label();
                rbtnAufgabe1 = new RadioButton();
                rbtnAufgabe2 = new RadioButton();
                cbxSolo = new CheckBox();
            }

            public SchuelerSelection(int pSchueler, int pLeft, int pTop) {

                gbxSelection = new GroupBox();
                lblSchueler = new Label();
                rbtnAufgabe1 = new RadioButton();
                rbtnAufgabe2 = new RadioButton();
                cbxSolo = new CheckBox();

                gbxSelection.Left = pLeft;
                gbxSelection.Top = pTop;
                gbxSelection.Height = 40;
                gbxSelection.Width = 335;
                
                lblSchueler.Left = 5;
                lblSchueler.Top = 15;
                
                rbtnAufgabe1.Left = 100;
                rbtnAufgabe1.Top = 10;
                rbtnAufgabe1.Width = 20;
                
                rbtnAufgabe2.Left = 205;
                rbtnAufgabe2.Top = 10;
                rbtnAufgabe2.Width = 20;

                cbxSolo.Left = 310;
                cbxSolo.Top = 10;
                cbxSolo.Width = 20;
                
                lblSchueler.Text = Convert.ToString(pSchueler);
                rbtnAufgabe1.Text = "";
                rbtnAufgabe2.Text = "";


                gbxSelection.Controls.Add(rbtnAufgabe1);
                gbxSelection.Controls.Add(rbtnAufgabe2);
                gbxSelection.Controls.Add(lblSchueler);
                gbxSelection.Controls.Add(cbxSolo);
            }

            public GroupBox getGroupBox() {

                return gbxSelection;
            }

            public Label getSchueler() {

                return lblSchueler;
            }

            public RadioButton getAufgabe1() {

                return rbtnAufgabe1;
            }

            public RadioButton getAufgabe2() {

                return rbtnAufgabe2;
            }

            public CheckBox getSolo() {

                return cbxSolo;
            }
        }

        private void btnEingeben_Click(object sender, EventArgs e) {

            int topPos = 0;
            

            if (nudSchueler.Value > 0 && nudGruppen.Value > 0) {

                lblSchueler.Visible = true;
                lblAufgabe1.Visible = true;
                lblAufgabe2.Visible = true;
                lblSolo.Visible = true;
                btnEinteilen.Visible = true;

                anzahlSchueler = Convert.ToInt32(nudSchueler.Value);
                gruppenGroesse = Convert.ToInt32(nudGruppen.Value);

                mSchueler = new SchuelerSelection[anzahlSchueler];

                for (int i = 0; i < anzahlSchueler; i++) {
                    
                    mSchueler[i] = new SchuelerSelection(i + 1, lblSchueler.Left, topPos);
                    pnlAuswahl.Controls.Add(mSchueler[i].getGroupBox());
                    topPos += 40;
                }
            } else {

                lblSchueler.Visible = false;
                lblAufgabe1.Visible = false;
                lblAufgabe2.Visible = false;
                lblSolo.Visible = false;
                btnEinteilen.Visible = false;

                pnlAuswahl.Controls.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {

            lblSchueler.Visible = false;
            lblAufgabe1.Visible = false;
            lblAufgabe2.Visible = false;
            lblSolo.Visible = false;
            btnEinteilen.Visible = false;

            pnlAuswahl.Controls.Clear();

            gruppenGroesse = 0;
            anzahlSchueler = 0;

            nudGruppen.Value = DEFAULTGRUPPEN;
            nudSchueler.Value = 0;
        }

        private void btnEinteilen_Click_1(object sender, EventArgs e) {

            //TODO check that all radio buttons selected

            int countAufgabe1 = 0;
            int iterAufgabe1 = 0;
            int countAufgabe2 = 0;
            int iterAufgabe2 = 0;

            mAuswahl = new string[anzahlSchueler, 4];

            // Schleife zur Determinierung der Groesse der einzelnen Aufgabengruppen.
            for (int i = 0; i < anzahlSchueler; i++) {
                
                if (mSchueler[i].getAufgabe1().Checked == true) {
                    
                    countAufgabe1++;
                } else {
                    
                    if (mSchueler[i].getAufgabe2().Checked == true) {
                        
                        countAufgabe2++;
                    }
                }
            }

            MessageBox.Show("Aufgabe1 " + countAufgabe1);
            MessageBox.Show("Aufgabe2 " + countAufgabe2);

            mAuswahlAufgabe1 = new string[countAufgabe1, 2];
            mAuswahlAufgabe2 = new string[countAufgabe2, 2];

            // Schueler den jeweiligen Gruppen zuteilen.
            for (int i = 0; i < anzahlSchueler; i++) {
                
                if (mSchueler[i].getAufgabe1().Checked == true) {
                    
                    mAuswahlAufgabe1[iterAufgabe1, 0] = Convert.ToString(mSchueler[i].getSchueler());
                    mAuswahlAufgabe1[iterAufgabe1, 1] = Convert.ToString(mSchueler[i].getSolo().Checked);
                    iterAufgabe1++;
                } else {
                    
                    if (mSchueler[i].getAufgabe2().Checked == true) {
                        
                        mAuswahlAufgabe2[iterAufgabe2, 0] = Convert.ToString(mSchueler[i].getSchueler());
                        mAuswahlAufgabe2[iterAufgabe2, 1] = Convert.ToString(mSchueler[i].getSolo().Checked);
                        iterAufgabe2++;
                    }
                }
            }

            MessageBox.Show("Aufgabe1 " + iterAufgabe1);
            MessageBox.Show("Aufgabe2 " + iterAufgabe2);

            /*
             * evtl keine volle liste aller benötigt
            for (int i = 0; i < anzahlSchueler; i++) {
                
                mAuswahl[i, 0] = Convert.ToString(mSchueler[i].getSchueler());
                mAuswahl[i, 1] = Convert.ToString(mSchueler[i].getAufgabe1().Checked);
                mAuswahl[i, 2] = Convert.ToString(mSchueler[i].getAufgabe2().Checked);
                mAuswahl[i, 3] = Convert.ToString(mSchueler[i].getSolo().Checked);
            }
             */
        }
    }
}
