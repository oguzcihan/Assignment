using AssignmentProject.Services;

namespace AssignmentProject
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void txtFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //numara giri�ine kapat�ld�
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                                                  && !char.IsSeparator(e.KeyChar);
        }

        private void txtSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece metin giri�i
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                                                  && !char.IsSeparator(e.KeyChar);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            cmbLang.SelectedIndex = 0; //Ge�erli dil T�rk�e
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Textbox kontrol
            //Toplama i�lemi butonu
            try
            {
                if (txtFirstNumber.Text == "" && txtSecondNumber.Text == "")
                {
                    //Textbox'lar bo� olma durumu hata g�nderildi
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else if (txtFirstNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                }
                else if (txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else
                {
                    errorProvider1.Clear();
                    var lang = cmbLang.SelectedItem.ToString(); //dil se�imi de�i�kene atand�
                    FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text, lang);
                    // firstnumber, secondnumber FunctionalityService class�na nesne arac�l��� ile g�nderildi.
                    txtResult.Text = functionalityService.AddProcess(); //�retilen nesneden AddProcess metodu �a�r�ld�.
                }
            }
            catch (ArithmeticException exception)
            {
                //ArithmeticException ile Int Max ve Min de�erleri a��m� yakaland�.
                Console.WriteLine(exception.StackTrace);
                MessageBox.Show("Int Max/Min de�eri a��ld�", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //��karma i�lemi butonuna bas�ld���nda;
       
            try
            {
                if (txtFirstNumber.Text == "" && txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else if (txtFirstNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                }
                else if (txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else
                {
                    errorProvider1.Clear();
                    var lang = cmbLang.SelectedItem.ToString();
                    FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text, lang);
                    // firstnumber, secondnumber FunctionalityService class�na nesne arac�l��� ile g�nderildi.
                    txtResult.Text = functionalityService.SubtractProcess(); //�retilen nesneden SubtractProcess metodu �a�r�ld�.
                }
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine(exception.StackTrace);
                MessageBox.Show("Int Max/Min de�eri a��ld�", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //�arpma i�lemi butonuna bas�ld���nda;
            try
            {
                if (txtFirstNumber.Text == "" && txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else if (txtFirstNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                }
                else if (txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else
                {
                    errorProvider1.Clear();
                   var lang = cmbLang.SelectedItem.ToString();
                    FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text, lang);
                    // firstnumber, secondnumber FunctionalityService class�na nesne arac�l��� ile g�nderildi.
                    txtResult.Text = functionalityService.MultiplyProcess(); //�retilen nesneden MultiplyProcess metodu �a�r�ld�.
                }
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine(exception.StackTrace);
                MessageBox.Show("Int Max/Min de�eri a��ld�", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //B�lme i�lemi butonuna bas�ld���nda;
            try
            {
                if (txtFirstNumber.Text == "" && txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else if (txtFirstNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                }
                else if (txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else
                {
                    errorProvider1.Clear();
                    var lang = cmbLang.SelectedItem.ToString();
                    FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text, lang);
                    // firstnumber, secondnumber FunctionalityService class�na nesne arac�l��� ile g�nderildi.
                    txtResult.Text = functionalityService.DivideProcess(); //�retilen nesneden MultiplyProcess metodu �a�r�ld�.
                }
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine(exception.StackTrace);
                MessageBox.Show("Int Max/Min de�eri a��ld�", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageText();
        }

        public void LanguageText()
        {
            if (cmbLang.SelectedIndex == 1)
            {
                txtFirstNumber.Clear();
                txtSecondNumber.Clear();
                txtResult.Clear();
                btnAdd.Text = "Add";
                btnSubtract.Text = "Subtract ";
                btnMultiply.Text = "Multiply";
                btnDivide.Text = "Divide";
                lblLangText.Text = "Current Language: "+"English";
                lblNumberone.Text = "First Number";
                lblNumbertwo.Text = "Second Number";
                grpResult.Text = "Result";
                grpLang.Text = "Language Selection";
                grpUser.Text = "User Input";
                lblNumberone.Location = new Point(94, 52);
                lblNumbertwo.Location = new Point(67, 98);
                txtFirstNumber.Location = new Point(213, 51);
                txtSecondNumber.Location = new Point(213, 96);


            }
            else
            {
                txtFirstNumber.Clear();
                txtSecondNumber.Clear();
                txtResult.Clear();
                btnAdd.Text = "Topla";
                btnSubtract.Text = "��kar ";
                btnMultiply.Text = "�arp ";
                btnDivide.Text = "B�l ";
                lblLangText.Text = "Ge�erli Dil: "+"T�rk�e";
                lblNumberone.Text = "Birinci Say�";
                lblNumbertwo.Text = "�kinci Say�";
                grpResult.Text = "Sonu�";
                grpLang.Text = "Dil Se�imi";
                grpUser.Text = "Kullan�c� Giri�i";
                lblNumberone.Location = new Point(108, 53);
                lblNumbertwo.Location = new Point(117, 98);
                txtFirstNumber.Location = new Point(213, 51);
                txtSecondNumber.Location = new Point(213, 96);

            }
        }
    }
}