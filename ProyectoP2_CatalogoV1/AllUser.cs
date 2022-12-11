using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP2_CatalogoV1
{
    class AllUser
    {
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();

        public AllUser() => VerUsuarios();

        public void VerUsuarios()
        {
            Users.Clear();
            string appDataPath = FileSystem.AppDataDirectory;
            IEnumerable<User> users = Directory

                                        .EnumerateFiles(appDataPath, "*.users.txt")

                                        .Select(filename => new User()
                                        {
                                            Filename = filename,
                                            Text = File.ReadAllText(filename),
                                            Date = File.GetCreationTime(filename)
                                        })

                                        .OrderBy(user => user.Date);

            foreach (User user in users)
                Users.Add(user);
        }
    }
}
