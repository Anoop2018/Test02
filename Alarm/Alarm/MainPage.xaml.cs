using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using Alarm.Model;
using Alarm.CustomControls;

namespace Alarm
{
    public partial class MainPage : ContentPage
    {
        //private SQLiteConnection conn;
        //public Alarm1 Alarm1;
        private Dictionary<int, string> myList;
        public MainPage()
        {
            InitializeComponent();

            myList = new RadioGroupDemoViewModel().LoadData();
            BindingContext = new {
                Values = myList
            };
            Alarm.CheckedChanged += MyRadiouGroup_CheckedChanged;
        }

        void MyRadiouGroup_CheckedChanged(object sender, int e)
        {
            var radio = sender as CustomRadioButton;

            if (radio == null || radio.Id == -1) return;

            txtSelected.Text = radio.Text;


        }
        //conn = DependencyService.Get<Sqlite>().getconnection();
        //conn.CreateTable<Alarm1>();
        //    var datalist = new List<String>();
        //    datalist.Add("UK");
        //    datalist.Add("India");
        //    this.BackgroundColor = Color.FromHex("#2bcbff");
        //    var headerlevel = new Label { Text = "Pickers", FontSize = 20, HorizontalOptions = LayoutOptions.Center };
        //    var dp = new DatePicker();
        //    {
        //        dp.MinimumDate = DateTime.Now;
        //    }
        //    var tp = new TimePicker();
        //    var datapicker = new Picker();
        //    {
        //        Title = "Select Location";
        //    }
        //    datapicker.ItemsSource = datalist;
        //    var submitbutton = new Button
        //    {
        //        Text = "Show Details",
        //        BackgroundColor = Color.Gray,
        //        TextColor = Color.Black
        //    };
        //    var detailslabel = new Label
        //    {

        //    };
        //    submitbutton.Clicked += showdetails;
        //    void showdetails(object sender, EventArgs e)
        //    {
        //        var getdate = dp.Date;
        //        var gettime = tp.Time;
        //        var getpickerdate = DatePicker.selectedItem;
        //        detailslabel.Text = String.Format("Date:{0}\n Time{1}\n Location:{2}", getdate, gettime, getpickerdate);
        //    }
        //    this.Content = new StackLayout
        //    {
        //        Padding = new Thickness(20),
        //        Children =
        //        {
        //            headerlevel,dp,tp,datapicker,submitbutton,detailslabel
        //        }
        //    };
    }

    //public void button_Clicked(object sender, EventArgs e)
    //{
    //    var tp = new TimePicker();
    //    timepicker.Children.Add(tp);
    //}
}