namespace examin_maksimov
{
    public partial class Form1 : Form
    {
        private Tec_DataBase _data;
        public Form1()
        {
            InitializeComponent();
            _data= new Tec_DataBase();
            _data.InInitialize();
            tec_data.DataSource= _data.tecs.ToList();
        }
    }
}