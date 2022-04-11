using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_11_April
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlDataAdapter;
        public string sqlQuery;

        private void labelVS_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtTeamHome = new DataTable();
            sqlQuery = "select team_id as `Team id`, team_name as `nama team` from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeamHome);
            comboBoxHome.DisplayMember = "nama team";
            comboBoxHome.ValueMember = "Team id";
            comboBoxHome.DataSource = dtTeamHome;

            DataTable dtTeam = new DataTable();
            sqlQuery = "select team_id as `Team id`, team_name as `nama team` from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeam);
            comboBoxTeam.DisplayMember = "nama team";
            comboBoxTeam.ValueMember = "Team id";
            comboBoxTeam.DataSource = dtTeam;
        }

        private void comboBoxHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtManagerTeamHome = new DataTable();
            sqlQuery = "SELECT manager.manager_name as `manager name`, player.player_name as `captain` " +
                "FROM team, player, manager " +
                "where team.captain_id = player.player_id and manager.manager_id = team.manager_id and team.team_id = '" + comboBoxHome.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtManagerTeamHome);
            lblManagerKiri.Text = dtManagerTeamHome.Rows[0]["manager name"].ToString();
            lblCaptainKiri.Text = dtManagerTeamHome.Rows[0]["captain"].ToString();


            DataTable dtstadium = new DataTable();
            sqlQuery = "SELECT concat(home_stadium, ', ', city) as `nama stadium`, capacity as `kapasitas` from team where team_id = '" + comboBoxHome.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtstadium);
            labelStadium.Text = dtstadium.Rows[0]["nama stadium"].ToString();
            labelKapasitas.Text = dtstadium.Rows[0]["kapasitas"].ToString();
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtmanagerteam = new DataTable();
            sqlQuery = "SELECT manager.manager_name as `manager name`, player.player_name as `captain` " +
                "FROM team, player, manager " +
                "where team.captain_id = player.player_id and manager.manager_id = team.manager_id and team.team_id = '" + comboBoxTeam.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtmanagerteam);
            lblManagerKanan.Text = dtmanagerteam.Rows[0]["manager name"].ToString();
            lblCaptainKanan.Text = dtmanagerteam.Rows[0]["captain"].ToString();

            DataTable dtstadium = new DataTable();
            sqlQuery = "SELECT concat(home_stadium, ', ', city) as `nama stadium`, capacity as `kapasitas` from team where team_id = '" + comboBoxTeam.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtstadium);
            labelStadium.Text = dtstadium.Rows[0]["nama stadium"].ToString();
            labelKapasitas.Text = dtstadium.Rows[0]["kapasitas"].ToString();
        }
    }
}
