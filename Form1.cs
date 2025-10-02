namespace ООП_ПР2_вар8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(r1.Text);
            TCircle c = new TCircle(r);
            result.Text = $"Площа круга: {c.AreaCircle():F2}";
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(r1.Text);
            TCircle c = new TCircle(r);
            result.Text = $"Довжина кола: {c.Length():F2}";
        }

        private void btnSector_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(r1.Text);
            double angle = Convert.ToDouble(k.Text);
            TCircle c = new TCircle(r);
            result.Text = $"Площа сектора: {c.AreaSector(angle):F2}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double rad1 = Convert.ToDouble(r1.Text);
            double rad2 = Convert.ToDouble(r2.Text);
            TCircle c1 = new TCircle(rad1);
            TCircle c2 = new TCircle(rad2);
            TCircle c3 = c1 + c2;
            result.Text = $"Новий радіус (c1+c2): {c3.Radius}";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double rad1 = Convert.ToDouble(r1.Text);
            double rad2 = Convert.ToDouble(r2.Text);
            TCircle c1 = new TCircle(rad1);
            TCircle c2 = new TCircle(rad2);
            TCircle c3 = c1 - c2;
            result.Text = $"Новий радіус (c1-c2): {c3.Radius}";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double rad1 = Convert.ToDouble(r1.Text);
            double kf = Convert.ToDouble(k.Text);
            TCircle c1 = new TCircle(rad1);
            TCircle c2 = c1 * kf;
            result.Text = $"Новий радіус (c1*k): {c2.Radius}";
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            double rad1 = Convert.ToDouble(r1.Text);
            double rad2 = Convert.ToDouble(r2.Text);
            TCircle c1 = new TCircle(rad1);
            TCircle c2 = new TCircle(rad2);
            result.Text = c1.Compare(c2) ? "Кола рівні" : "Кола не рівні";
        }
    }
}
