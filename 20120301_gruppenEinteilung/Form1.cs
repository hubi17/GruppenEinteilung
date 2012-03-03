/*
 * Program to generate random groups for given tasks.
 * Written by Daniel Auhuber, FSI 1
 * 01/03/2012
 */

/*
 * TODO
 * -Positionierung mittels Point statt Top und Left.
 * -init method to set sane default values.
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

        const int DEFAULTGRUPPENGROESSE = 2;
        int anzahlSchueler = 0;
        int gruppenGroesse = 0;
        SchuelerSelection[] mSchueler;
        string[,] mAuswahl;
        string[,] mAuswahlAufgabe1;
        string[,] mAuswahlAufgabe2;
        GruppenSelection[] mAufgabe1;
        GruppenSelection[] mAufgabe2;
        Random mRnd = new Random();
        // variable to store used indeces for random groups
        int[] mIndeces;
        int mIndexPos;

        public Form1() {
            
            InitializeComponent();
            nudGruppen.Value = DEFAULTGRUPPENGROESSE;
        }

        public class GruppenSelection {

            private GroupBox gbxSelection;
            // TODO array of labels to dynamically generate group size
            private Label lblSchueler1;
            private Label lblSchueler2;
            private static int gruppenZaehler = 1;

            public GruppenSelection() {

                gbxSelection = new GroupBox();
                lblSchueler1 = new Label();
                lblSchueler2 = new Label();
                gruppenZaehler++;
            }

            public GruppenSelection(string pSchueler1, string pSchueler2, int pLeft, int pTop) {

                gbxSelection = new GroupBox();
                lblSchueler1 = new Label();
                lblSchueler2 = new Label();

                gbxSelection.Left = pLeft;
                gbxSelection.Top = pTop;
                gbxSelection.Height = 65;
                gbxSelection.Width = 220;
                gbxSelection.Text = "Gruppe " + gruppenZaehler;

                lblSchueler1.Left = 5;
                lblSchueler1.Top = 15;

                lblSchueler2.Left = 5;
                lblSchueler2.Top = 40;

                lblSchueler1.Text = pSchueler1;
                lblSchueler2.Text = pSchueler2;

                gbxSelection.Controls.Add(lblSchueler1);
                gbxSelection.Controls.Add(lblSchueler2);

                gruppenZaehler++;
            }

            public GroupBox getGroupBox() {

                return gbxSelection;
            }

            public static void resetZaehler() {

                gruppenZaehler = 1;
            }
        }

        public class SchuelerSelection {

            private GroupBox gbxSelection;
            private TextBox tbxSchueler;
            private RadioButton rbtnAufgabe1;
            private RadioButton rbtnAufgabe2;
            private CheckBox cbxSolo;
            //checkbox fuer einzelgruppe

            public SchuelerSelection() {

                gbxSelection = new GroupBox();
                tbxSchueler = new TextBox();
                rbtnAufgabe1 = new RadioButton();
                rbtnAufgabe2 = new RadioButton();
                cbxSolo = new CheckBox();
            }

            public SchuelerSelection(int pSchueler, int pLeft, int pTop) {

                gbxSelection = new GroupBox();
                tbxSchueler = new TextBox();
                rbtnAufgabe1 = new RadioButton();
                rbtnAufgabe2 = new RadioButton();
                cbxSolo = new CheckBox();

                gbxSelection.Left = pLeft;
                gbxSelection.Top = pTop;
                gbxSelection.Height = 40;
                gbxSelection.Width = 335;
                
                tbxSchueler.Left = 5;
                tbxSchueler.Top = 15;
                
                rbtnAufgabe1.Left = 100;
                rbtnAufgabe1.Top = 10;
                rbtnAufgabe1.Width = 20;
                
                rbtnAufgabe2.Left = 205;
                rbtnAufgabe2.Top = 10;
                rbtnAufgabe2.Width = 20;

                cbxSolo.Left = 310;
                cbxSolo.Top = 10;
                cbxSolo.Width = 20;
                
                tbxSchueler.Text = Convert.ToString(pSchueler);
                rbtnAufgabe1.Text = "";
                rbtnAufgabe2.Text = "";


                gbxSelection.Controls.Add(rbtnAufgabe1);
                gbxSelection.Controls.Add(rbtnAufgabe2);
                gbxSelection.Controls.Add(tbxSchueler);
                gbxSelection.Controls.Add(cbxSolo);
            }

            public GroupBox getGroupBox() {

                return gbxSelection;
            }

            public TextBox getSchueler() {

                return tbxSchueler;
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

            int vTopPos = 0;
            
            //reset output panel
            pnlAuswahl.Controls.Clear();

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
                    
                    mSchueler[i] = new SchuelerSelection(i + 1, lblSchueler.Left, vTopPos);
                    pnlAuswahl.Controls.Add(mSchueler[i].getGroupBox());
                    vTopPos += 40;
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
            pnlAufgabe1.Controls.Clear();

            gruppenGroesse = 0;
            anzahlSchueler = 0;

            nudGruppen.Value = DEFAULTGRUPPENGROESSE;
            nudSchueler.Value = 0;

            GruppenSelection.resetZaehler();
        }

        private void btnEinteilen_Click_1(object sender, EventArgs e) {

            //TODO check that all radio buttons selected
            //may not be needed as certain students not put into groups

            int countAufgabe1 = 0;
            int iterAufgabe1 = 0;
            int countAufgabe2 = 0;
            int iterAufgabe2 = 0;
            int vTopPos = 0;

            mAuswahl = new string[anzahlSchueler, 4];

            // reset output panels
            // IMPORTANT!!!! - makes pressing button multiple times generate new random groups
            pnlAufgabe1.Controls.Clear();
            pnlAufgabe2.Controls.Clear();

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

            mAuswahlAufgabe1 = new string[countAufgabe1, 2];
            mAuswahlAufgabe2 = new string[countAufgabe2, 2];

            // Schueler den jeweiligen Gruppen zuteilen.
            for (int i = 0; i < anzahlSchueler; i++) {
                
                if (mSchueler[i].getAufgabe1().Checked == true) {
                    
                    mAuswahlAufgabe1[iterAufgabe1, 0] = mSchueler[i].getSchueler().Text;
                    mAuswahlAufgabe1[iterAufgabe1, 1] = Convert.ToString(mSchueler[i].getSolo().Checked);
                    iterAufgabe1++;
                } else {
                    
                    if (mSchueler[i].getAufgabe2().Checked == true) {
                        
                        mAuswahlAufgabe2[iterAufgabe2, 0] = mSchueler[i].getSchueler().Text;
                        mAuswahlAufgabe2[iterAufgabe2, 1] = Convert.ToString(mSchueler[i].getSolo().Checked);
                        iterAufgabe2++;
                    }
                }
            }

            //group1
            mIndeces = new int[countAufgabe1];
            GruppenSelection.resetZaehler();
            // initialize array with -1 indeces
            for (int i = 0; i < countAufgabe1; i++) {
                
                mIndeces[i] = -1;
            }

            mIndexPos = 0;
            mAufgabe1 = new GruppenSelection[countAufgabe1 / DEFAULTGRUPPENGROESSE];

            // check for uneven group size
            for (int i = 0; i < countAufgabe1 / DEFAULTGRUPPENGROESSE; i++) {

                mAufgabe1[i] = gruppeEinteilen(mAuswahlAufgabe1, countAufgabe1, vTopPos);
                pnlAufgabe1.Controls.Add(mAufgabe1[i].getGroupBox());
                vTopPos += 80;
            }

            mAufgabe1 = aufgabeEinteilen(countAufgabe1);
            mAufgabe2 = aufgabeEinteilen(countAufgabe2);

            lblEinteilungAufgabe1.Visible = true;
            lblEinteilungAufgabe2.Visible = true;
        }

        private GruppenSelection[] aufgabeEinteilen(int pGruppenGroesse) {

            int vTopPos = 0;
            GruppenSelection[] vReturn = new GruppenSelection[pGruppenGroesse / DEFAULTGRUPPENGROESSE];

            // reset Zaehler for each group
            GruppenSelection.resetZaehler();

            // reset index array
            mIndeces = new int[pGruppenGroesse];

            // initialize array with -1 indeces
            for (int i = 0; i < pGruppenGroesse; i++) {

                mIndeces[i] = -1;
            }

            mIndexPos = 0;

            for (int i = 0; i < pGruppenGroesse / DEFAULTGRUPPENGROESSE; i++) {

                mAufgabe2[i] = gruppeEinteilen(mAuswahlAufgabe2, pGruppenGroesse, vTopPos);
                pnlAufgabe2.Controls.Add(mAufgabe2[i].getGroupBox());
                vTopPos += 80;
            }

            return vReturn;

        }

        private GruppenSelection gruppeEinteilen(string[,] pAuswahlAufgabe, int pCountAufgabe, int pTopPos) {

            GruppenSelection vReturn;
            int vRandom1 = 0;
            int vRandom2 = 0;

            vRandom1 = getRandomIndex(pCountAufgabe);
            vRandom2 = getRandomIndex(pCountAufgabe);

            vReturn = new GruppenSelection(pAuswahlAufgabe[vRandom1, 0],
                                           pAuswahlAufgabe[vRandom2, 0],
                                           5, pTopPos);

            return vReturn;
        }

        private int getRandomIndex(int pMaxRange) {

            int vRandom = 0;
            bool mUnique = false;

            while (!mUnique) {
                
                vRandom = mRnd.Next(pMaxRange);
                mUnique = true;
                
                for (int i = 0; i <= mIndexPos; i++) {
                    
                    if (vRandom == mIndeces[i]) {
                        
                        mUnique = false;
                    }
                }

            }

            // add vRandom to array of used indeces.
            mIndeces[mIndexPos] = vRandom;
            mIndexPos++;

            return vRandom;
        }
    }
}
