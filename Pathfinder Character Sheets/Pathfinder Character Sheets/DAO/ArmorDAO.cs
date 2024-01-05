using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pathfinder_Character_Sheets_Server.Models;
using Pathfinder_Character_Sheets_Server.Exceptions;


namespace Pathfinder_Character_Sheets_Server.DAO
{
    public class ArmorDAO : IArmorDAO
    {
        private readonly string connectionString;
        public ArmorDAO(string dbConnectionString)

        {
            connectionString = dbConnectionString;
        }

        public Armor AddArmor(Armor armor)
        {
            string sql = "INSERT INTO armor ( armor_weight_class, armor_description, armor_name, is_magical, is_masterwork, magical_modifier, armor_class" +
                "VALUES(@armor_weight_class, @armor_description, @armor_name, @is_magical, @is_masterwork, @magical_modifier, @armor_class" +
                "SELECT SCOPE_IDENTITY;";

            try
            {
                int newArmorId;
                using(var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@armor_weight_class", armor.ArmorWeightClass);
                    cmd.Parameters.AddWithValue("@armor_description", armor.ArmorDescription);
                    cmd.Parameters.AddWithValue("@armor_name", armor.ArmorName);
                    cmd.Parameters.AddWithValue("@is_magical", armor.IsMagical);
                    cmd.Parameters.AddWithValue("@is_masterwork", armor.IsMasterwork);
                    cmd.Parameters.AddWithValue("@magical_modifier", armor.MagicalModifier);
                    cmd.Parameters.AddWithValue("@armor_class", armor.ArmorClass);

                  newArmorId = Convert.ToInt32(cmd.ExecuteScalar());

                    armor = FindArmorById(newArmorId);  


                }
            }
            catch (SqlException ex)
            {
                throw new DaoException("SQL Exception Occurred", ex);
            }
            return armor;

        }

        public Armor DeleteArmor(int id)
        {
            throw new NotImplementedException();
        }

        public Armor FindArmorById(int id)
        {
            Armor armor = null;
            string sql = "SELECT * FROM armor WHERE armor_id = @armor_id";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@armor_id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        armor = MapRowToArmor(reader);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw new DaoException("SQL exception occurred", ex);
            }
            return armor;
        }

        public List<Armor> GetAllArmors()
        {
            List<Armor> armorList = new List<Armor>();

            string sql = "SELECT * FROM armor";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    var cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Armor armors = new Armor();
                        armors = MapRowToArmor(reader);
                        armorList.Add(armors);

                        
                    }
                }
            }
            catch(SqlException ex)
            {
                throw new DaoException("SQL Exception Occurred", ex);
            }
            return armorList;
        }

        public List<Armor> GetArmors(int characterId)
        {
            throw new NotImplementedException();
        }

        public Armor UpdateArmor(Armor armor)
        {
            throw new NotImplementedException();
        }

        private Armor MapRowToArmor(SqlDataReader reader)
        {
            Armor armor = new Armor();
            armor.ArmorId = Convert.ToInt32(reader["armor_id"]);
            armor.ArmorWeightClass = Convert.ToString(reader["armor_weight_class"]);
            armor.ArmorDescription = Convert.ToString(reader["armor_description"]);
            armor.ArmorName = Convert.ToString(reader["armor_name"]);
            armor.IsMagical = Convert.ToBoolean(reader["is_magical"]);
            armor.IsMasterwork = Convert.ToBoolean(reader["is_masterwork"]);
            armor.MagicalModifier = Convert.ToInt32(reader["magical_modifier"]);
            armor.ArmorClass = Convert.ToInt32(reader["armor_class"]);
            return armor;

        }

    }
}
