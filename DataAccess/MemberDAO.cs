using As01.BusinessObject;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> memList = new List<MemberObject>()
        {
            new MemberObject(){MemberID = 1,MemberName = "Anh Long",Email ="longa@fstore.email" ,Pass= "123",City="Hà Nội", Country="Việt Nam" },
            new MemberObject(){MemberID= 2, MemberName= "Thị Hồng", Email= "hongt@fstore.email", Pass= "234567", City= "Hồ Chí Minh", Country= "Việt Nam" },
            new MemberObject(){MemberID= 3, MemberName= "Thị Thắm", Email= "thamt@fstore.email", Pass= "235678", City= "Đà Nẵng", Country= "Việt Nam" },
            new MemberObject(){MemberID= 4, MemberName= "Văn Quang", Email= "quangv@fstore.email", Pass= "236789", City= "Hà Nội", Country= "Việt Nam" },
            new MemberObject(){MemberID= 5, MemberName= "Jeff Bezos", Email= "bezosj@fstore.email", Pass= "237890", City= "Seattle", Country= "Mỹ"},
            new MemberObject(){MemberID= 6, MemberName= "David Kane", Email= "kaned@fstore.email", Pass= "238901", City= "Sydney", Country= "Úc" },
            new MemberObject(){MemberID= 7, MemberName= "Fushigoro Tomi", Email= "tomif@fstore.email", Pass= "239012", City= "Tokyo", Country= "Nhật" },
            
            new MemberObject(){MemberID= 8, MemberName= "Mai Linh", Email= "linhm@fstore.email", Pass= "240123", City= "Canberra", Country= "Úc" },
            new MemberObject(){MemberID= 9, MemberName= "Akira Sato", Email= "satoa@fstore.email", Pass= "241234", City= "Osaka", Country= "Nhật" },
            new MemberObject(){MemberID= 10, MemberName= "Emily Watson", Email= "watsone@fstore.email", Pass= "242345", City= "New York", Country= "Mỹ" },
            
            new MemberObject(){MemberID= 11, MemberName= "Nguyễn Minh", Email= "minhn@fstore.email", Pass= "243456", City= "Nha Trang", Country= "Việt Nam" },
            new MemberObject(){MemberID= 12, MemberName= "Lucas Brown", Email= "brownl@fstore.email", Pass= "244567", City= "Melbourne", Country= "Úc" },
            new MemberObject(){MemberID= 13, MemberName= "Yuki Tanaka", Email= "tanakay@fstore.email", Pass= "245678", City= "Sapporo", Country= "Nhật" },
            new MemberObject(){MemberID= 14, MemberName= "Sarah Connor", Email= "connors@fstore.email", Pass= "246789", City= "Los Angeles", Country= "Mỹ" },
            new MemberObject(){MemberID= 15, MemberName= "Trần Huy", Email= "huyt@fstore.email", Pass= "247890", City= "Đà Lạt", Country= "Việt Nam" },
            new MemberObject(){MemberID= 16, MemberName= "Sophie Turner", Email= "turners@fstore.email", Pass= "248901", City= "Brisbane", Country= "Úc" },
            new MemberObject(){MemberID= 17, MemberName= "Kaito Nagasaki", Email= "nagasakik@fstore.email", Pass= "249012", City= "Kyoto", Country= "Nhật" },
            new MemberObject(){MemberID= 18, MemberName= "John Smith", Email= "smithj@fstore.email", Pass= "250123", City= "Chicago", Country= "Mỹ"},
            new MemberObject(){MemberID= 19, MemberName= "Phạm Tú", Email= "tup@fstore.email", Pass= "251234", City= "Hải Phòng", Country= "Việt Nam"},
            new MemberObject(){MemberID= 20, MemberName= "Grace Lee", Email= "leeg@fstore.email", Pass= "252345", City= "Adelaide", Country= "Úc" },
            new MemberObject(){MemberID= 21, MemberName= "Haruto Watanabe", Email= "watanabeh@fstore.email", Pass= "253456", City= "Nagoya", Country= "Nhật" },
            new MemberObject(){MemberID= 22, MemberName= "Elizabeth Jones", Email= "jonese@fstore.email", Pass= "254567", City= "San Francisco", Country= "Mỹ"},
            new MemberObject(){MemberID= 23, MemberName= "Lê Thảo", Email= "thaol@fstore.email", Pass= "255678", City= "Phú Quốc", Country= "Việt Nam" },
            new MemberObject(){MemberID= 24, MemberName= "Abigail Green", Email= "greena@fstore.email", Pass= "256789", City= "Perth", Country= "Úc" },
            new MemberObject(){MemberID= 25, MemberName= "Hiroshi Kobayashi", Email= "kobayashih@fstore.email", Pass= "257890", City= "Hiroshima", Country= "Nhật" },
            new MemberObject(){MemberID= 26, MemberName= "Michael Johnson", Email= "johnsonm@fstore.email", Pass= "258901", City= "Miami", Country= "Mỹ" },
            new MemberObject(){MemberID= 27, MemberName= "Đỗ Trang", Email= "trangd@fstore.email", Pass= "259012", City= "Buôn Ma Thuột", Country= "Việt Nam" },
            new MemberObject(){MemberID= 28, MemberName= "Hannah Wilson", Email= "wilsonh@fstore.email", Pass= "260123", City= "Darwin", Country= "Úc" },
            new MemberObject(){MemberID= 29, MemberName= "Ryota Suzuki", Email= "suzukir@fstore.email", Pass= "261234", City= "Fukuoka", Country= "Nhật" },
            new MemberObject(){MemberID= 29, MemberName= "Ryota Suzuki", Email= "suzukir@fstore.email", Pass= "261234", City= "Fukuoka", Country= "Nhật"},
            new MemberObject(){MemberID= 31, MemberName= "Bùi Duy", Email= "duyb@fstore.email", Pass= "263456", City= "Vinh", Country= "Việt Nam" },
            new MemberObject(){MemberID= 32, MemberName= "Lê Hà", Email= "hal@fstore.email", Pass= "264567", City= "Hà Nội", Country= "Việt Nam" },
            new MemberObject(){MemberID= 33, MemberName= "Nguyễn Mai", Email= "main@fstore.email", Pass= "265678", City= "Hồ Chí Minh", Country= "Việt Nam" },
            new MemberObject(){MemberID= 34, MemberName= "Phạm Lan", Email= "lanp@fstore.email", Pass= "266789", City= "Đà Nẵng", Country= "Việt Nam" },
            new MemberObject(){MemberID= 35, MemberName= "Trần Hương", Email= "huongt@fstore.email", Pass= "267890", City= "Nha Trang", Country= "Việt Nam" },
            new MemberObject(){MemberID= 36, MemberName= "Võ Phương", Email= "phuongv@fstore.email", Pass= "268901", City= "Hải Phòng", Country= "Việt Nam" },
            new MemberObject(){MemberID= 37, MemberName= "Đặng Khánh", Email= "khanhd@fstore.email", Pass= "269012", City= "Đà Lạt", Country= "Việt Nam" },
            new MemberObject(){MemberID= 38, MemberName= "Hoàng Nam", Email= "namh@fstore.email", Pass= "270123", City= "Phú Quốc", Country= "Việt Nam" },
            new MemberObject(){MemberID= 39, MemberName= "Bùi Tâm", Email= "tamb@fstore.email", Pass= "271234", City= "Buôn Ma Thuột", Country= "Việt Nam" },
            new MemberObject(){MemberID= 40, MemberName= "Ngô Trung", Email= "trungn@fstore.email", Pass= "272345", City= "Vinh", Country= "Việt Nam" },
            new MemberObject(){MemberID= 41, MemberName= "Lý Hồng", Email= "hongl@fstore.email", Pass= "273456", City= "Hà Nội", Country= "Việt Nam" },

            new MemberObject(){MemberID= 42, MemberName= "Olivia Johnson", Email= "johnsono@fstore.email", Pass= "274567", City= "New York", Country= "Mỹ" },
            new MemberObject(){MemberID= 43, MemberName= "Emma Williams", Email= "williamse@fstore.email", Pass= "275678", City= "Los Angeles", Country= "Mỹ" },
            new MemberObject(){MemberID= 44, MemberName= "Ava Brown", Email= "browna@fstore.email", Pass= "276789", City= "Chicago", Country= "Mỹ" },
            new MemberObject(){MemberID= 45, MemberName= "Sophia Jones", Email= "joness@fstore.email", Pass= "277890", City= "Miami", Country= "Mỹ" },
            new MemberObject(){MemberID= 46, MemberName= "Isabella Garcia", Email= "gariciai@fstore.email", Pass= "278901", City= "San Francisco", Country= "Mỹ" },
            new MemberObject(){MemberID= 47, MemberName= "Mia Davis", Email= "davism@fstore.email", Pass= "279012", City= "Seattle", Country= "Mỹ" },
            new MemberObject(){MemberID= 48, MemberName= "Charlotte Martinez", Email= "martinezc@fstore.email", Pass= "280123", City= "Houston", Country= "Mỹ" },
            new MemberObject(){MemberID= 49, MemberName= "Amelia Rodriguez", Email= "rodrigueza@fstore.email", Pass= "281234", City= "New York", Country= "Mỹ" },
            new MemberObject(){MemberID= 50, MemberName= "Harper Gonzalez", Email= "gonzalezh@fstore.email", Pass= "282345", City= "Los Angeles", Country= "Mỹ" },
            new MemberObject(){MemberID= 51, MemberName= "Evelyn Anderson", Email= "andersone@fstore.email", Pass= "283456", City= "Chicago", Country= "Mỹ" },

            new MemberObject(){MemberID= 52, MemberName= "William Smith", Email= "smithw@fstore.email", Pass= "284567", City= "Sydney", Country= "Úc" },
            new MemberObject(){MemberID= 53, MemberName= "Jack Brown", Email= "brownj@fstore.email", Pass= "285678", City= "Melbourne", Country= "Úc" },
            new MemberObject(){MemberID= 54, MemberName= "Noah Wilson", Email= "wilsonn@fstore.email", Pass= "286789", City= "Brisbane", Country= "Úc" },
            new MemberObject(){MemberID= 55, MemberName= "James Jones", Email= "jonesj@fstore.email", Pass= "287890", City= "Perth", Country= "Úc" },
            new MemberObject(){MemberID= 56, MemberName= "Oliver Martin", Email= "martino@fstore.email", Pass= "288901", City= "Adelaide", Country= "Úc" },
            new MemberObject(){MemberID= 57, MemberName= "Benjamin Lee", Email= "leeb@fstore.email", Pass= "289012", City= "Canberra", Country= "Úc" },
            new MemberObject(){MemberID= 58, MemberName= "Lucas King", Email= "kingl@fstore.email", Pass= "290123", City= "Sydney", Country= "Úc" },
            new MemberObject(){MemberID= 59, MemberName= "Mason Walker", Email= "walkerm@fstore.email", Pass= "291234", City= "Melbourne", Country= "Úc" },
            new MemberObject(){MemberID= 60, MemberName= "Ethan Harris", Email= "harrise@fstore.email", Pass= "292345", City= "Brisbane", Country= "Úc" },
            new MemberObject(){MemberID= 61, MemberName= "Alexander Young", Email= "younga@fstore.email", Pass= "293456", City= "Perth", Country= "Úc" },

            new MemberObject(){MemberID= 62, MemberName= "Haruto Yamada", Email= "yamadah@fstore.email", Pass= "294567", City= "Tokyo", Country= "Nhật" },
            new MemberObject(){MemberID= 63, MemberName= "Yuki Nakamura", Email= "nakamuray@fstore.email", Pass= "295678", City= "Osaka", Country= "Nhật" },
            new MemberObject(){MemberID= 64, MemberName= "Sota Tanaka", Email= "tanakas@fstore.email", Pass= "296789", City= "Kyoto", Country= "Nhật" },
            new MemberObject(){MemberID= 65, MemberName= "Riku Suzuki", Email= "suzukir@fstore.email", Pass= "297890", City= "Sapporo", Country= "Nhật" },
            new MemberObject(){MemberID= 66, MemberName= "Aoi Takahashi", Email= "takahashia@fstore.email", Pass= "298901", City= "Hiroshima", Country= "Nhật" },
            new MemberObject(){MemberID= 67, MemberName= "Hina Saito", Email= "saitoh@fstore.email", Pass= "299012", City= "Fukuoka", Country= "Nhật" },
            new MemberObject(){MemberID= 68, MemberName= "Yuma Watanabe", Email= "watanabey@fstore.email", Pass= "300123", City= "Nagoya", Country= "Nhật" },
            new MemberObject(){MemberID= 69, MemberName= "Rei Kato", Email= "katou@fstore.email", Pass= "301234", City= "Tokyo", Country= "Nhật" },
            new MemberObject(){MemberID= 70, MemberName= "Nao Kobayashi", Email= "kobayashin@fstore.email", Pass= "302345", City= "Osaka", Country= "Nhật" },
            new MemberObject(){MemberID= 71, MemberName= "Mei Ito", Email= "itom@fstore.email", Pass= "303456", City= "Kyoto", Country= "Nhật" }

        };
        //==========Singleton
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public List<MemberObject> GetMemberList => memList;
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                }
                return instance;
            }
        }

        public MemberObject getMemberById(int mId)
        {
            MemberObject mem = memList.SingleOrDefault(mem => mem.MemberID == mId);
            return mem;
        }
        public List<MemberObject> getMembersByName(string name)
        {
            List<MemberObject> mem = memList.Where(mem => mem.MemberName.Contains(name)).ToList();
            return mem;
        }
        public List<MemberObject> getMembersByCountry(string country, string name)
        {
            List<MemberObject> mem = memList.Where(mem => mem.Country.Contains(country)).Where(mem => mem.MemberName.Contains(name)).ToList();
            return mem;
        }
        public List<MemberObject> getMembersByCity(string city, string name)
        {
            List<MemberObject> mem = memList.Where(mem => mem.City.Contains(city)).Where(mem => mem.MemberName.Contains(name)).ToList();
            return mem;
        }

        public void Update(MemberObject mem)
        {
            MemberObject obj = getMemberById(mem.MemberID);
            if (obj != null)
            {
                int tmp = memList.IndexOf(obj);
                memList[tmp].MemberID = mem.MemberID;
                memList[tmp].MemberName = mem.MemberName;
                memList[tmp].Email = mem.Email;
                memList[tmp].City = mem.City;
                memList[tmp].Country = mem.Country;
                memList[tmp].Pass = mem.Pass;
            }
            else
            {
                throw new Exception("Member do not exists.");
            }
        }

        public void Delete(MemberObject mem) {
            MemberObject obj = getMemberById(mem.MemberID);
            if(obj != null)
            {
                memList.Remove(obj);
            }
            else
            {
                throw new Exception("Member do not exists.");
            }
        }

        public void AddNew(MemberObject mem)
        {
            int id = memList[memList.Count - 1].MemberID;
            mem.MemberID = id+1;
            memList.Add(mem);
        }
       public List<string> getCities(string country)
        {
            List<string> tmp = memList.Where(mem => mem.Country.Contains(country)).Select(mem => mem.City).Distinct().ToList();

            return tmp;
        }

        public List<string> getCities()
        {
            List<string> tmp = memList.OrderBy(mem => mem.Country).Select(mem => mem.City).Distinct().ToList();

            return tmp;
        }
        public List<string> getCountry()
        {
            List<string> tmp = memList.Select(mem => mem.Country).Distinct().ToList();

            return tmp;
        }

        public MemberObject checkMem(string mail,string pass)
        {
            MemberObject tmp = memList.SingleOrDefault(mem => mem.Email.Equals(mail));
            if(tmp != null)
            {
                return tmp;
            }
            return null;
        }

    }
}
