namespace D1{
    public static class Program {
        static List<Member> members = new List<Member>
        {
            new Member
            {
                FirstName = "Phuong",
                LastName = "Nguyen Nam",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 1, 22),
                PhoneNumber = "",
                BirthPlace = "Phu Tho",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Nam",
                LastName = "Nguyen Thanh",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 1, 20),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Son",
                LastName = "Do Hong",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 11, 6),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Huy",
                LastName = "Nguyen Duc",
                Gender = "Male",
                DateOfBirth = new DateTime(1996, 1, 26),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Hoang",
                LastName = "Phuong Viet",
                Gender = "Male",
                DateOfBirth = new DateTime(1999, 2, 5),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Long",
                LastName = "Lai Quoc",
                Gender = "Male",
                DateOfBirth = new DateTime(1997, 5, 30),
                PhoneNumber = "",
                BirthPlace = "Bac Giang",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Thanh",
                LastName = "Tran Chi",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 9, 18),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Miss",
                LastName = "Nguyen Thanh",
                Gender = "Female",
                DateOfBirth = new DateTime(1996, 1, 20),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            }
        };
        static void Main(String[] args){
            // 1. Return all Male Members
            // var maleMembers = GetMaleMembers();
            // PrintData(maleMembers);

            // 2. Return oldest Members
            // var oldestMember = GetOldestMember();
            // PrintData(new List<Member> {oldestMember});

            // 3. Return full name of all members
            // var fullnames = GetFullNames();
            // for (int i = 0; i < fullnames.Count; i++)
            // {
            //     string? fullname = fullnames[i];
            //     Console.WriteLine($"{i+1} {fullname}");
            // }

            // 4. Split members by birth year
            // var results = SplitMembersByBirthYear();
            // Console.WriteLine("---------------2000-----------");
            // PrintData(results.Item1);
            // Console.WriteLine("-------Greater than 2000------");
            // PrintData(results.Item2);
            // Console.WriteLine("-------Lower than 2000--------");
            // PrintData(results.Item3);

            // 5. Get members by birth place
            // var result = GetMembersByBirthPlace("Ha noi");
            // PrintData(result);
        }

        static void PrintData(List<Member> data)
        {
            var index = 0;
            foreach(var item in data)
            {
                ++index;
                Console.WriteLine($"{index}. {item.FirstName} {item.LastName} {item.DateOfBirth.ToString("dd/MM/yyyy")} [{item.Age}] {item.BirthPlace}.");
            }
        }

        static List<Member> GetMaleMembers()
        {
            var result = new List<Member>();
            foreach(var member in members)
            {
                if(member.Gender == "Male")
                {
                    result.Add(member);
                }
            }
            return result;
        }

        static Member GetOldestMember()
        {
            var maxDays = members[0].TotalDays;
            var maxAgeIndex = 0;

            for(var i = 1; i < members.Count; i++)
            {
                var member = members[i];
                if(member.TotalDays > maxDays)
                {
                    maxDays = member.TotalDays;
                    maxAgeIndex = i;
                }
            }

            return members[maxAgeIndex];
        }

        static List<string> GetFullNames()
        {
            var result = new List<string>();
            foreach(var member in members)
            {
                result.Add($"{member.LastName} {member.FirstName}");
            }
            return result;
        }

        static Tuple<List<Member>, List<Member>, List<Member>> SplitMembersByBirthYear()
        {
            var list1 = new List<Member>();
            var list2 = new List<Member>();
            var list3 = new List<Member>();

            foreach(var member in members)
            {
                var birthYear = member.DateOfBirth.Year;
                switch(birthYear)
                {
                    case 2000:
                        list1.Add(member);
                        break;
                    case > 2000:
                        list2.Add(member);
                        break;
                    case < 2000:
                        list3.Add(member);
                        break;
                }
            }

            return Tuple.Create(list1, list2, list3);
        }

        static List<Member> GetMembersByBirthPlace(string place)
        {
            var result = new List<Member>();
            foreach(var member in members)
            {
                if(member.BirthPlace.Equals(place, StringComparison.CurrentCultureIgnoreCase))
                {
                    result.Add(member);
                }
            }
            return result;
        }
    }
}
