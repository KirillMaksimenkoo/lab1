namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quadrangle quadrangle;

            double aab, bbc, ccd, aad, kyt11, kyt22;

            try
            {
                aab = Convert.ToDouble(ab.Text);
                bbc = Convert.ToDouble(bc.Text);
                ccd = Convert.ToDouble(cd.Text);
                aad = Convert.ToDouble(ad.Text);

                quadrangle = new Quadrangle(aab, bbc, ccd, aad, 0, 0);

                label1.Text = quadrangle.Perevirka1();

            }
            catch
            {
                MessageBox.Show("Помилка при введенні даних");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quadrangle quadrangle;

            double kyt11, kyt22;

            try
            {
                kyt11 = Convert.ToDouble(kyt1.Text);
                kyt22 = Convert.ToDouble(kyt2.Text);
                quadrangle = new Quadrangle(0, 0, 0, 0, kyt11, kyt22);

                label2.Text = quadrangle.Perevirka2();
            }
            catch
            {
                MessageBox.Show("Помилка при введенні даних");
            }
        }
    }
}