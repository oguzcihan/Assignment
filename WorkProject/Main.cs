namespace WorkProject
{
    public partial class Main : Form
    {

        private CombineService _CombineService = new CombineService();

        public Main()
        {
            InitializeComponent();

        }


        private void txtFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece metin giri�i
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                                                  && !char.IsSeparator(e.KeyChar);
        }

        private void txtSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece metin giri�i
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                                                  && !char.IsSeparator(e.KeyChar);
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            //textbox kontrol
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
                addProcess(); //toplama i�lem methodu
                lblStatus.Text = "Toplama ��lemi Ba�ar�l�.";
            }

        }

        public void addProcess()
        {
            string birinciMetin = txtFirstNumber.Text;
            string birinciSayi = _CombineService.ConvertToNumber(birinciMetin).ToString();

            string ikinciMetin = txtSecondNumber.Text;
            string ikinciSayi = _CombineService.ConvertToNumber(ikinciMetin).ToString();

            int sayibir = int.Parse(birinciSayi);
            int sayiiki = int.Parse(ikinciSayi);
            int total = sayibir + sayiiki;
            txtResult.Text = _CombineService.ConvertToWord(total);
        }



        private void btnCikar_Click(object sender, EventArgs e)
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
                subtractProcess(); //��karma i�lem methodu
                lblStatus.Text = "��karma ��lemi Ba�ar�l�.";
            }

        }

        public void subtractProcess()
        {
            string birinciMetin = txtFirstNumber.Text;
            //string birinciSayi= _CombineService.ConvertToNumbers(birinciMetin).ToString();
            string birinciSayi = _CombineService.ConvertToNumber(birinciMetin).ToString();
            string ikinciMetin = txtSecondNumber.Text;
            //string ikinciSayi = _CombineService.ConvertToNumbers(ikinciMetin).ToString();
            string ikinciSayi = _CombineService.ConvertToNumber(ikinciMetin).ToString();

            int sayibir = int.Parse(birinciSayi);
            int sayiiki = int.Parse(ikinciSayi);
            int total = sayibir - sayiiki;
            if (total < 0)
            {
                string toplam = total.ToString();
                toplam = toplam.Substring(1);
                txtResult.Text = "eksi " + _CombineService.ConvertToWord(int.Parse(toplam));
            }
            else if (total == 0)
            {
                txtResult.Text = "S�f�r";
            }
            else
            {
                txtResult.Text = _CombineService.ConvertToWord(total);
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void btnCarp_Click(object sender, EventArgs e)
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
                multiplyProcess(); //�arpma i�lem methodu
                lblStatus.Text = "�arpma ��lemi Ba�ar�l�.";
            }

        }

        private void multiplyProcess()
        {
            string birinciMetin = txtFirstNumber.Text;
            //string birinciSayi= _CombineService.ConvertToNumbers(birinciMetin).ToString();
            string birinciSayi = _CombineService.ConvertToNumber(birinciMetin).ToString();
            //txtResult.Text = birinciSayi;

            string ikinciMetin = txtSecondNumber.Text;
            //string ikinciSayi = _CombineService.ConvertToNumbers(ikinciMetin).ToString();
            string ikinciSayi = _CombineService.ConvertToNumber(ikinciMetin).ToString();

            int sayibir = int.Parse(birinciSayi);
            int sayiiki = int.Parse(ikinciSayi);
            int total = sayibir * sayiiki;
            txtResult.Text = _CombineService.ConvertToWord(total);
        }

        private void btnBol_Click(object sender, EventArgs e)
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
                divideProcess(); //b�lme i�lem methodu
                lblStatus.Text = "B�lme ��lemi Ba�ar�l�.";
            }

        }

        private void divideProcess()
        {

            string birinciMetin = txtFirstNumber.Text;
            string ikinciMetin = txtSecondNumber.Text;
            if (birinciMetin == "s�f�r" && ikinciMetin == "s�f�r")
            {
                txtResult.Text = "S�f�r";
            }
            else if (ikinciMetin == "s�f�r")
            {
                txtResult.Text = "Tan�ms�z";
            }
            else
            {
                string birinciSayi = _CombineService.ConvertToNumber(birinciMetin).ToString();
                string ikinciSayi = _CombineService.ConvertToNumber(ikinciMetin).ToString();
                int sayibir = int.Parse(birinciSayi);
                int sayiiki = int.Parse(ikinciSayi);
                int total = sayibir / sayiiki;

                txtResult.Text = _CombineService.ConvertToWord(total);
            }

        }
    }
}