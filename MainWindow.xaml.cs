using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;

namespace PetitJeu1310
{
    /// <summary>
    /// Création de variables globales
    /// Pour les utiliser, on utilise Global.***
    /// </summary>
    public class Global
    {
        public static string LeMot;
        public static int essai;
        public static List<char> LettresMot = new List<char>();
        public static List<char> lettreTrouves = new List<char>();
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Par défaut pour utiliser l'interface graphique
            InitializeComponent();
            // On attribut à ntore variable de type LIST une LISTE contenant les lettres du mot choisit
            Global.LettresMot = IntialisationJeu();
            // On lance cette méthode afin de remplacer le vide par des lettres.
            CheckLettres();
        }
        /// <summary>
        /// Fonction CheckLetters qui sert à remplacer le texte nommé LblMot par soit des tirets, soit des lettres
        /// </summary>
        /// <param name="LaLettre">Lettre sur laquelle l'utilisateur à appuyé</param>
        public void CheckLettres(char LaLettre = 'x')
        {
            /// On réinitialise le texte dans le Label afin de pouvoir le réutiliser ensuite sous la forme de 
            /// LblMot.Content = LblMot.Content + ......
            LblMot.Content = "";
            // On fait une boucle afin de parcourir toue la liste afin de tester chacune des lettres
            foreach (char ToutesLesLettres in Global.LettresMot)
            {
                // On initialise une variable de type booléen afin de savoir si la lettre mentionnée
                // dans "LaLettre" est égale à l'une des lettres du mot 
                bool cayest = false;
                // On vérifie que la lettre n'a pas été trouvée dans une liste 
                foreach (char LettreTrouvee in Global.lettreTrouves)
                {
                    // Si la lettre à été trouvée, on passe le boolean cayest à VRAI
                    if(ToutesLesLettres == LettreTrouvee)
                    {
                        cayest = true;
                    }
                    // SINON, ON NE FAIS RIEN, pour ne pas écraser la variable
                }
                // Si la lettre n'a pas été trouvée et n'a pas encore été proposée
                if(cayest == false)
                {
                    // On remplace la lettre par un tiret dans le mot
                    LblMot.Content = LblMot.Content + " - ";
                } else 
                {
                    // Sinon, on affiche LES lettres contenant cette lettre,
                    // meme si cela y est plusieurs fois dans le mot
                    LblMot.Content = LblMot.Content + Convert.ToString(ToutesLesLettres);
                }
                if(Convert.ToString(LblMot.Content) == Convert.ToString(Global.LeMot))
                {
                    // Si le mot affichée est égal au mot proposé, l'utilisateur à gagné. On lui dit
                    MessageBox.Show("Vous avez gagné avec " + Global.essai + " erreurs sur un total de " + Global.LeMot.Length + " lettres.");
                }
            }
        }
        /// <summary>
        /// Fonction pour remettre toutes les touches en active et réinitialisation des variables.
        /// </summary>
        public List<char> IntialisationJeu()
        {
            // On change le texte du Label contenant le mot par du vide afin d'initialiser le programme
            LblMot.Content = "";
            // On vide le tableau des lettres trouvés, dans le cas où l'utilisateur souhaite rejouer
            Global.lettreTrouves.Clear();
            // On lance cette méthode afin de remplacer le vide par des lettres.
            CheckLettres('a');

            // Pour le BTN lettre A:
            Button _Btn_A = A as Button;
            _Btn_A.IsEnabled = true;

            // Pour le BTN lettre B:
            Button _Btn_B = B as Button;
            _Btn_B.IsEnabled = true;

            // Pour le BTN lettre C:
            Button _Btn_C = C as Button;
            _Btn_C.IsEnabled = true;

            // Pour le BTN lettre D:
            Button _Btn_D = D as Button;
            _Btn_D.IsEnabled = true;

            // Pour le BTN lettre E:
            Button _Btn_E = E as Button;
            _Btn_E.IsEnabled = true;

            // Pour le BTN lettre F:
            Button _Btn_F = F as Button;
            _Btn_F.IsEnabled = true;

            // Pour le BTN lettre G:
            Button _Btn_G = G as Button;
            _Btn_G.IsEnabled = true;

            // Pour le BTN lettre H:
            Button _Btn_H = H as Button;
            _Btn_H.IsEnabled = true;

            // Pour le BTN lettre I:
            Button _Btn_I = I as Button;
            _Btn_I.IsEnabled = true;

            // Pour le BTN lettre J:
            Button _Btn_J = J as Button;
            _Btn_J.IsEnabled = true;

            // Pour le BTN lettre K:
            Button _Btn_K = K as Button;
            _Btn_K.IsEnabled = true;

            // Pour le BTN lettre L:
            Button _Btn_L = L as Button;
            _Btn_L.IsEnabled = true;

            // Pour le BTN lettre M:
            Button _Btn_M = M as Button;
            _Btn_M.IsEnabled = true;

            // Pour le BTN lettre N:
            Button _Btn_N = N as Button;
            _Btn_N.IsEnabled = true;

            // Pour le BTN lettre O:
            Button _Btn_O = O as Button;
            _Btn_O.IsEnabled = true;

            // Pour le BTN lettre P:
            Button _Btn_P = P as Button;
            _Btn_P.IsEnabled = true;

            // Pour le BTN lettre Q:
            Button _Btn_Q = Q as Button;
            _Btn_Q.IsEnabled = true;

            // Pour le BTN lettre R:
            Button _Btn_R = R as Button;
            _Btn_R.IsEnabled = true;

            // Pour le BTN lettre S:
            Button _Btn_S = S as Button;
            _Btn_S.IsEnabled = true;

            // Pour le BTN lettre T:
            Button _Btn_T = T as Button;
            _Btn_T.IsEnabled = true;

            // Pour le BTN lettre U:
            Button _Btn_U = U as Button;
            _Btn_U.IsEnabled = true;

            // Pour le BTN lettre V:
            Button _Btn_V = V as Button;
            _Btn_V.IsEnabled = true;

            // Pour le BTN lettre W:
            Button _Btn_W = W as Button;
            _Btn_W.IsEnabled = true;

            // Pour le BTN lettre X:
            Button _Btn_X = X as Button;
            _Btn_X.IsEnabled = true;

            // Pour le BTN lettre Y:
            Button _Btn_Y = Y as Button;
            _Btn_Y.IsEnabled = true;

            // Pour le BTN lettre Z:
            Button _Btn_Z = Z as Button;
            _Btn_Z.IsEnabled = true;

            // On défini un nouveau client Web grâce au constructeur
            WebClient client = new WebClient();
            // On va chercher un mot sur ce lien 
            // Je n'ai pas trouvé d'API proposant JUSTE un mot en français,
            // Alors j'en ai codé une moi même en PHP. 
            // Je vais juste chercher dans une base de données.
            // Je verrais pour intégrer la base de données à C# au prochain TP
            // Il y a 600 parties possibles pour le moment.

            // La page web renvoie un mot, alors on stock la réponse de la page web dans une variable
            string downloadString = client.DownloadString("https://yanish.fr/_mot.php");

            // On met dans la variable globale la réponse de la page web
            Global.LeMot = Convert.ToString(downloadString.ToUpper());

            // On fait une boucle allant de 0 a la taile du mot, de pas 1 en 1
            for (int i = 0; i < Global.LeMot.Length; i++)
            {
                // On ajouter dans la liste LettresMot la lettre situé à l'index I
                Global.LettresMot.Add(Global.LeMot[i]);
            }
            // On initialise la variable essai à 0
            Global.essai = 0;
            
            // On retourne une liste contenant la liste des lettres du mot généré par la page web
            return Global.LettresMot;

        }

        /// <summary>
        /// Lorsqu'on appuie sur une touche, cette fonction se déclanche.
        /// </summary>
        /// <param name="NomDeTouche">Lettre qui est sur la touche</param>
        /// <param name="LeMot">Mot qui a été généré via l'API</param>
        public void AppuiBtn(char NomDeTouche, string LeMot)
        {
            // On déclare une variable de type booléen et on lui attribut la valeur FAUX
            bool LettreTrouvee = false;

            // On parcours la liste contenant toutes les lettres du mot
            foreach (char ToutesLesLettres in Global.LettresMot)
            {
                // Si la lettre appuyée est contenue dans le mot
                if(NomDeTouche == ToutesLesLettres)
                {
                    // Lettre trouvée dans la liste
                    LettreTrouvee = true;
                    
                    // On ajoute dans la liste des lettres trouvée la touche appuyée
                    Global.lettreTrouves.Add(NomDeTouche);
                    
                    // On utilise la fonction CheckLettres pour remplacer le texte
                    CheckLettres(NomDeTouche);
                }
                // IL NE FAUT SURTOUT PAS FAIRE DE ELSE ici. Sinon, cela va faire bugger le programme
            }
            // Si la lettre apputée n'est pas contenue dans le mot
            if (LettreTrouvee == false)
            {
                // On ajoute 1 au nombre d'essaies effectués
                Global.essai = Global.essai + 1;
            }
            // Au bout du 8ème essai (car il y a 8 images)
            if(Global.essai > 7)
            {
                // On avertir l'utilisateur qu'il a perdu
                MessageBox.Show("Perdu. Vous avez fait plus de 7 erreurs. Le mot était " + Global.LeMot);

                // Réinitialisation des variables pour utilisation dans une nouvelle partie sans relancer le programme
                Global.essai = 0;
                Global.LeMot = "";
                Global.LettresMot.Clear();
                Global.lettreTrouves.Clear();
                LblMot.Content = "";
                Global.LettresMot = IntialisationJeu();
                CheckLettres();
            }
            // A chaque fois qu'une touche est appuyée on recharge l'image.
            // Si la variable Global.essai à été incrémentée, l'image sera modifié
            // Dans le cas contraire, l'image ne changera pas
            Uri resourceUri = new Uri(Global.essai + ".png", UriKind.Relative);
            Img.Source = new BitmapImage(resourceUri);
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            // Lorsqu'un boutton est appuyé
            Button _btn = sender as Button;

            // On récupère le caractère dans le contenu du boutton
            char Btn = Convert.ToChar(_btn.Content);
            
            // On désactive le boutton pour ne pas a avoir à gérer dans le code l'appuie de 2 fois sur le même button
            _btn.IsEnabled = false;
            
            // On déclanche une fonction prenant comme argument la lettre préssée et le mot définit en varible globale
            AppuiBtn(Btn, Global.LeMot);
        }

    }
}
