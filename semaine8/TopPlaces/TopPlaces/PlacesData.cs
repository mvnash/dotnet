using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TopPlaces
{
    public class PlacesData
    {
        private IList<Place> placesList;


        public PlacesData()
        {
            string pathProject = Environment.CurrentDirectory;
            Place p1 = new Place(pathProject + "/photos/bruxelles.jpg", "Bruxelles");
            Place p2 = new Place(pathProject + "/photos/paris.jpg", "Paris");
            Place p3 = new Place(pathProject + "/photos/moscou.jpg", "Moscou");
            Place p4 = new Place(pathProject + "/photos/amsterdam.jpg", "Amsterdam");
            Place p5 = new Place(pathProject + "/photos/newyork.jpg", "New York");

            placesList = new List<Place>();
            placesList.Add(p1);
            placesList.Add(p2);
            placesList.Add(p3);
            placesList.Add(p4);
            placesList.Add(p5);
        }
    }

    public class Place
    {
        private String _description;
        private String _pathImageFile;
        private int _nbVotes;
        private Uri _uri;
        private BitmapFrame _image;

        public Place(string path, string description)
        {
            _description = description;
            _pathImageFile = path;
            _nbVotes = 0;
            _uri = new Uri(_pathImageFile);
            _image = BitmapFrame.Create(_uri);
        }

        public String getDescription() { return _description; }

        public String getPathImageFile() { return _pathImageFile; }
        public int getNbVotes() { return _nbVotes; }
        public Uri getUri() { return _uri; }
        public BitmapFrame getImage() { return _image; }
        public void setImage(BitmapFrame image) { _image = image; }
        public void setUri(Uri uri) { _uri = uri; }
        public void setNbVotes(int nbVotes) { _nbVotes = nbVotes; }
        public void setPathImageFile(String pathImageFile) { _pathImageFile = pathImageFile; }
        public void setDescription(String description) { _description = description; }
    }
}
