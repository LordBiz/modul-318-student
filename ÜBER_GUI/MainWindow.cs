using SwissTransport;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ÜBER_GUI
{
    public partial class MainWindow : Form
    {
        // Variablen
        string SearchFrom = "";
        string SearchTo = "";
        Transport transport = new Transport();
        bool isArrivalTime = false;
        string MailContent = "";

        //Konstruktor
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Leert die Listview und stellt Verbindungen/Abfahrten dar.
        /// Wenn beide Textboxen befüllt wurden, werden Verbindungen gesucht.
        /// Wenn nur die Erste befüllt wurde, wird die Abfahrtstafel gesucht.
        /// </summary>
        private void Search_Click(object sender, EventArgs e)
        {
            MailContent = "";
            ConnectionsListView.Items.Clear();
            // Verbindungen suchen & darstellen
            if (StartStation.Text != "" && EndStation.Text != "")
            {
                Connections Connection = transport.GetConnections(SearchFrom, SearchTo, DatePicker.Value, TimePicker.Value, isArrivalTime);
                foreach (var item in Connection.ConnectionList)
                {
                    ListViewItem i = new ListViewItem(item.From.Station.Name);
                    i.SubItems.Add(item.To.Station.Name);
                    i.SubItems.Add(DateTime.Parse(item.From.Departure).ToShortTimeString());
                    i.SubItems.Add(DateTime.Parse(item.To.Arrival).ToShortTimeString());
                    i.SubItems.Add(item.Duration.Substring(3));
                    ConnectionsListView.Items.Add(i);
                    MailContent = String.Format("{0}{1}Von: {2}; Nach: {3}; Abfahrt: {4}; Ankunft: {5}; Dauer: {6};", 
                        MailContent, Environment.NewLine, item.From.Station.Name, item.To.Station.Name, DateTime.Parse(item.From.Departure).ToShortTimeString(), DateTime.Parse(item.To.Arrival).ToShortTimeString(), item.Duration.Substring(3));
                }
            }
            // Abfahrten suchen & darstellen
            else if (StartStation.Text != "" && EndStation.Text == "")
            {
                StationBoardRoot StationBoard = transport.GetStationBoard(SearchFrom, DatePicker.Value, TimePicker.Value);
                foreach (var item in StationBoard.Entries)
                {
                    ListViewItem i = new ListViewItem(item.Name);
                    i.SubItems.Add(item.To);
                    i.SubItems.Add(item.Stop.Departure.ToShortTimeString());
                    i.SubItems.Add("");
                    i.SubItems.Add("");
                    ConnectionsListView.Items.Add(i);
                }
            }
        }

        /// <summary>
        /// Setzt SearchFrom zum Inhalt des "Von"-Felds.
        /// Setzt die AutoCompleteCustomSource zur Stationsliste
        /// </summary>
        private void StartStationChanged(object sender, EventArgs e)
        {
            SearchFrom = StartStation.Text;
            StartStation.AutoCompleteCustomSource = CreateAutocompleteList(SearchFrom);
        }

        /// <summary>
        /// Setzt SearchFrom zum Inhalt des "Nach"-Felds.
        /// Setzt die AutoCompleteCustomSource zur Stationsliste
        /// </summary>
        private void EndStationChanged(object sender, EventArgs e)
        {
            SearchTo = EndStation.Text;
            EndStation.AutoCompleteCustomSource = CreateAutocompleteList(SearchTo);
        }

        /// <summary>
        /// Sucht nach den Stationen, die ähndlich dem mitgegebenen String sind.
        /// Gibt eine AutoCompleteStringCollection mit den Stationen zurück
        /// </summary>
        private AutoCompleteStringCollection CreateAutocompleteList(string Search)
        {
            AutoCompleteStringCollection AllowedOptions = new AutoCompleteStringCollection();
            AllowedOptions.Clear();

            if (SearchTo.Length > 3)
            {
                Stations station = transport.GetStations(Search);
                AllowedOptions.AddRange(station.StationList.Select(x => x.Name).ToArray());
            }
            return AllowedOptions;
        }

        /// <summary>
        /// Setzt den Wert des DatePickers auf das heutige Datum,
        /// falls das Datum vor heute ist
        /// </summary>
        private void DatePickerChanged(object sender, EventArgs e)
        {
            if (DatePicker.Value < DateTime.Today)
            {
                DatePicker.Value = DateTime.Today;
            }
        }

        /// <summary>
        /// Setzt ob nach einer Ankunfts- oder einer Abfahrtszeit gesucht wird
        /// </summary>
        private void ComboBoxAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            isArrivalTime = false;
            if (ComboBoxAD.SelectedIndex == 1)
            {
                isArrivalTime = !isArrivalTime;
            }
        }

        /// <summary>
        /// Öffnet ein Mail-Fenster und gibt den Content Text mit
        /// </summary>
        private void SendMail_Click(object sender, EventArgs e)
        {
            MailWindow Mail = new MailWindow(MailContent);
            Mail.Show();
        }
    }
}
