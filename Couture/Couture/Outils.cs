using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Text.RegularExpressions;



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
        public static Boolean CbxVoidControl(ComboBox cbxATraiter)
        {
            Boolean code = true;
            if (cbxATraiter.SelectedIndex== -1 && cbxATraiter.Text.Trim() == "")
            {
                MessageBox.Show("Sélectionnez un élément de la liste ou saisissez une entrée");
                cbxATraiter.BackColor = Color.Blue;
                cbxATraiter.Focus();
                code = false;
                
            }

            return code;

        }

        /// <summary>
        /// Verifie qu'une valeur est bien numérique (int, float, d'une longueur arbitrairement fixée à 7 caracteres)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Boolean EstUneValeurNumerique(string s)
        {

            Boolean code = false; //Code retour; OK à priori

            string pattern = @"^[0-9]+((\.|,)[0-9]+){0,1}$";
            // On estime que la longueur max que l'utilisateur pourra entrer sera de 7 caractères (ex pour prix metrage : 9000,99
            //Cela fait déjà assez cher le tissu, et on considère que le tissu peut être gratuit
            if (s.Length < 8 && s.Length > 0)
            {

                    //RegEx, vérifier que ce qui est saisi est bien soit un entier soit un nombre décimal
                   if (Regex.IsMatch(s, pattern))
                    {
                        code = true;
                    }
                
            }
            return code;
        }

        /// <summary>
        /// Attribue une valeur à la cbx (soit l'item selectionné, soit l'item saisi)
        /// </summary>
        /// <param name="cbxATraiter"></param>
        /// <returns></returns>
        public static string AttribuerValeurCbx(ComboBox cbxATraiter)
        {
            string attributAAffecter = null;
            if (cbxATraiter.Text.Trim() != "")
            {
                attributAAffecter = cbxATraiter.Text.Trim();


            }
            else if (cbxATraiter.SelectedIndex > -1)
            {
                attributAAffecter = cbxATraiter.SelectedItem.ToString();


            }
            return attributAAffecter;
        }


        
    }
}

