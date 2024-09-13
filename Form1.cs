namespace CSharpHDD_Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            HinhChuNhat hinhChuNhat = new HinhChuNhat();
            hinhChuNhat.setCd(int.Parse(txt_cd.Text));
            hinhChuNhat.setCr(int.Parse(txt_cr.Text));

            MessageBox.Show("Chiều dài:" + hinhChuNhat.getCd() +"\nChiều rộng:" + hinhChuNhat.getCr());
        }
    }
}
