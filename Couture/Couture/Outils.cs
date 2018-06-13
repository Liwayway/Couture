using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace Couture
{

    /// <summary>
    /// classe outils pour :
    /// - contrôles de saisie 
    /// - fonctions communes à tous
    /// </summary>
    public class Outils
    {



        /// <summary>
        /// fonction générique de contrôle qu'une chaine reçue pourra se convertir en Int32
        /// </summary>
        /// <param name="s">une String à convertir</param>
        /// <returns>Booléen (vrai = OK, false = erreur)</returns>
        public static Boolean EstEntier(String s)
        {
            /* vérifier que la chaine reçue représente bien un entier valide :
             * - uniquement des chiffres
             * - pas vide
             * - pas plus de 9 chiffres (capacité maxi du type Int32)
             */
            Int32 i;            // indice de parcours de chaîne
            Char c;             // caractère courant
            Boolean code = true;   // code retour; OK a priori

            // test longueur chaîne reçue
            if (s.Length < 10 && s.Length > 0)
            {
                // vérifier 1 à 1 que tous les caractères sont des chiffres
                for (i = 0; i < s.Length; i++)
                {
                    c = s[i]; // extrait le i° car
                    if (!(Char.IsDigit(c))) // si ce n'est pas un chiffre
                    {
                        code = false; // erreur détectée
                    }
                } // fin de boucle for
            }
            else // erreur de longueur de chaine
            {
                code = false; // erreur détectée
            }
            return code;
        }

        //Créer un controle de saisie pour les float


        /// <summary>
        /// Permet à l'ouverture d'un form d'alimenter les combobox de ce dernier 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="cbxAAlimenter"></param>
        /// <param name="contenuAAfficher"></param>
        public static void AlimenterCombobox(string query, ComboBox cbxAAlimenter, string contenuAAfficher)
        {
            MySqlCommand cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
            cmd.CommandText = query;
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                cbxAAlimenter.Items.Add(dataReader[contenuAAfficher]);
            }
            dataReader.Close();
        }

        /// <summary>
        /// Permet de vérifier que l'utilisateur a soit saisi un text soit sélectionné un élément de la liste
        /// </summary>
        /// <param name=""></param>
        public string CbxVoidControl(ComBoBox cbxATraiter)
        {
            string attributAAffecter;
            while (cbxATraiter.SelectedIndex() == -1 || cbxATraiter.Text.ToTrim() == null)
            {
                MessageBox.Show("Sélectionnez un élément de la liste ou saisissez une entrée");
                cbxATraiter.BackColor = Color.Blue;
                cbxATraiter.Focus();
                attributAAffecter = null;
                
            }

            if (cbxATraiter.Text.ToTrim() != null)
            {
                attributAAffecter = cbxATraiter.Text.ToTrim();
                

            }
            else if (cbxATraiter.SelectedIndex() > -1)
            {
                attributAAffecter = cbxATraiter.SelectedItem.ToString();
                

            }
            return attributAAffecter;

        }
        /*public static void ControleSaisieCombobox (ComboBox cbxAControler, string nomTable, string nomChamp)
        {
            for (int i = 0; i < cbxAControler.Items.Count; i++)
            {
                //string value = ;

                if (cbxAControler.Text == cbxAControler.GetItemText(cbxAControler.Items[i]))
                {
                    MessageBox.Show("Cette" + nomChamp +"existe déjà dans la liste, veuillez la sélectionner.");
                }
                else if (cbxAControler.Text != cbxAControler.GetItemText(cbxAControler.Items[i]))
                {
                    //Appel de la méthode insertcouleur
                    InsertCbxTextInto(nomTable, nomChamp, cbxAControler);
                }
            }

        }*/

        /*public static void InsertCbxTextInto (string nomTable, string nomChamp, ComboBox cbxConcerne)
        {
            MySqlCommand cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
            cmd.CommandText = "INSERT IGNORE INTO " + nomTable + " (" + nomChamp + ") VALUES ("
            + cbxConcerne.Text.ToString().ToLower() + ");";

            cmd.ExecuteNonQuery();
        }*/
    }
}
