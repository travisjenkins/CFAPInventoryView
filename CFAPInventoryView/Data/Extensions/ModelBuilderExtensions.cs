using CFAPInventoryView.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace CFAPInventoryView.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgeGroup>().HasData(
                    new AgeGroup
                    {
                        AgeGroupId = new Guid("ED2DA6D8-A312-489D-B7D0-253D75C6C820"),
                        Description = "0-6 months",
                        SortOrder = 0,
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new AgeGroup 
                    { 
                        AgeGroupId = new Guid("E7581E8F-E2AC-4550-AAC7-D4FF7FE778E1"),
                        Description = "6-12 months",
                        SortOrder = 1,
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new AgeGroup 
                    { 
                        AgeGroupId = new Guid("39D9931F-E6A6-449D-AA69-D7AAD053E298"),
                        Description = "1-2",
                        SortOrder = 2,
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new AgeGroup
                    {
                        AgeGroupId = new Guid("75200021-5B2F-4079-96BE-7E38A1AD1ADB"),
                        Description = "3-6",
                        SortOrder = 3,
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new AgeGroup
                    {
                        AgeGroupId = new Guid("F574F025-F5C3-4611-96D7-AD679E6B1467"),
                        Description = "7-11",
                        SortOrder = 4,
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new AgeGroup
                    {
                        AgeGroupId = new Guid("290C1063-F288-46EF-8377-3113586B7C62"),
                        Description = "12-18",
                        SortOrder = 5,
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    }
                );
            modelBuilder.Entity<Ethnicity>().HasData(
                    new Ethnicity
                    {
                        EthnicityId = new Guid("0040E5C2-0D7F-4DB8-A7E8-28C5EFA6CF4F"),
                        Description = "Black/Mixed Race",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Ethnicity
                    {
                        EthnicityId = new Guid("B5C934B6-C7E0-493F-8726-C3FD5FF2141F"),
                        Description = "White/Hispanic",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    }
                );
            modelBuilder.Entity<Gender>().HasData(
                    new Gender
                    {
                        GenderId = new Guid("78CC56F2-717B-45CB-B025-09C0CCA68F27"),
                        Description = "Girl",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Gender
                    {
                        GenderId = new Guid("629F93B9-15D1-4AAB-A0A6-9AB22E6AC159"),
                        Description = "Boy",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Gender
                    {
                        GenderId = new Guid("AEDB28BC-17DE-436E-8348-217802299584"),
                        Description = "Neutral",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    }
                );
            modelBuilder.Entity<ExcludeCategory>().HasData(
                    new ExcludeCategory
                    {
                        ExcludeCategoryId = new Guid("BB0C0779-5261-4D14-8A96-12FF3E0D8DFF"),
                        Name = "Items requiring batteries",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new ExcludeCategory
                    {
                        ExcludeCategoryId = new Guid("9FE23DD1-3946-4456-8C5D-5808458EAFD3"),
                        Name = "Items with spiral binding",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new ExcludeCategory
                    {
                        ExcludeCategoryId = new Guid("5CEF1269-2589-4A6F-A150-5ED172D16A1A"),
                        Name = "Baby food or formula",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new ExcludeCategory
                    {
                        ExcludeCategoryId = new Guid("EBFEF241-8ABB-4B02-89A1-9A5D19893C11"),
                        Name = "Used items",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new ExcludeCategory
                    {
                        ExcludeCategoryId = new Guid("F77CBFAA-11CD-44E7-ABB7-E3E0F030E212"),
                        Name = "Sharp objects such as razors or manicure sets",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new ExcludeCategory
                    {
                        ExcludeCategoryId = new Guid("695B89CF-9C4D-4AD4-AF45-E9D0422D41EF"),
                        Name = "Food or beverages",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    }
                );
            modelBuilder.Entity<OptionalCategory>().HasData(
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("A2197138-9321-473E-891F-1507671D43D7"),
                        Name = "Satin bonnet or hair scarf",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("4A0E060B-E159-49AF-9ECD-1790F8D7A0B3"),
                        Name = "Adhesive bandages/band-aids",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("1D6AD3D8-D44C-4982-A912-24454286FEAD"),
                        Name = "Small toy",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("741217D0-A963-489A-863D-2570BB91C4E5"),
                        Name = "Hair gel",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("D9CAF847-0312-4808-979B-25B5BFFC4FB8"),
                        Name = "Oil/cream moisturizer for curly hair",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("989A01F0-8F0E-468C-AB51-2C6501348672"),
                        Name = "Small backpack",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    }, 
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("D0193BC7-1A7F-48A2-BEE5-2D5402A2C66F"),
                        Name = "Sleep sack",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("7C65FB61-080A-4FF7-9D27-37904280E926"),
                        Name = "Wave brush or Denman brush",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("A698B945-513B-4379-A13C-398F31E47BB6"),
                        Name = "Backpack or drawstring bag",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("18DB181A-39C7-4FF6-AA5F-504C9FD42495"),
                        Name = "Baby towel and washcloths",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("84F608E3-E046-4CFC-9525-56677374CCE9"),
                        Name = "Children's book",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("6C31ED18-3271-4434-AF24-5697A341ED6E"),
                        Name = "Nerf ball or fidget toy",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("337E6455-6BCB-4241-A3B8-58C7A6F2200C"),
                        Name = "Themed adhesive band-aids",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("AA154101-BCE0-4973-B9AA-7291F06B571C"),
                        Name = "Infant nail clippers",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("02561934-85A8-4EF0-A890-82092B240FB4"),
                        Name = "Burp cloths",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("678425C7-3B3E-4F23-B073-8268F4CE273A"),
                        Name = "Aquaphor healing ointment",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("010A1CC4-259B-4198-A841-92A5B784787D"),
                        Name = "Gift card (Walmart/Target)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("E58DE252-2495-4A19-94B4-9641320FA900"),
                        Name = "Soft bristle brush",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("743C8970-B53D-496C-9EE9-96C0BE328F55"),
                        Name = "Kids satin night cap/bonnet",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("86EECF1B-D8BB-4526-A9C1-9B3D511EC50F"),
                        Name = "Coloring or sketch book, and colored pencils",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("B9A71948-1AC2-4E86-BDA7-9DDE074BE330"),
                        Name = "Hair accessories",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("B88A0B8B-0460-4FA6-B5CF-9F94261FD823"),
                        Name = "Toiletry bag",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("373FFCAF-8C96-4DC5-B7FD-A5247E1A62CD"),
                        Name = "Crib Sheet",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("BF55FCFC-CE99-436C-8127-AA6898AF039F"),
                        Name = "Diaper cream",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("811F6A9A-0845-4116-A3F6-B1C0CD3A5912"),
                        Name = "Toy (e.g. chunky puzzle, baby doll, toy car)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("DE8BBEA2-FFFE-4073-9ACC-B91C45A05A2C"),
                        Name = "Chapstick",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("15423C38-CBD8-4B49-BBB8-BA74804189E2"),
                        Name = "Baby brush/comb",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("6C1F919D-8B90-43F0-9BF4-C4D69ED6537D"),
                        Name = "Body lotion",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("355CFDC5-4EF5-4EF1-B881-C5CEDE5D6270"),
                        Name = "Hair lotion, oil, or gel",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("85BCB30F-F902-485D-A82F-C9544D435DF5"),
                        Name = "Face wipes or face wash",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("D03154FF-DA79-4B02-B231-CD0D8494C2E5"),
                        Name = "Thermometer",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("34F51FD8-5E64-46DF-BEB9-D3CAAD869F22"),
                        Name = "Activity book and crayons/pencils",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("A31F289E-A7B7-4B51-AE96-D742A3DBF460"),
                        Name = "Wave cap or satin hair tie",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("7E95C73E-2251-4680-B71A-ED86F3951EFB"),
                        Name = "Shower cap",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new OptionalCategory
                    {
                        OptionalCategoryId = new Guid("2D024344-DD8E-49BB-A069-EF59A2625D34"),
                        Name = "Bulb aspirator",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    }
                );
            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        CategoryId = new Guid("A6760763-1106-426C-AEB9-05142ABA7F57"),
                        Name = "Maxi pads or tampons",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("07EBD8CF-F55B-47A9-BF52-072A1F89E16F"),
                        Name = "Body wash or mild soap (unscented)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("D24A4561-F64B-4371-943C-0D4AC6E9BE57"),
                        Name = "Hair brush or comb",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("C50504D5-A7EC-4AAB-ACAE-0ED0A39D1578"),
                        Name = "Infant toy (0-6 months)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("6EB9D0BB-C37F-4BA0-A911-0F76BE2FB119"),
                        Name = "Package of socks (size youth small)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("1DB3A928-231F-48F2-ACAF-16747CFDD4AD"),
                        Name = "Deck of cards",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("C37A088F-7112-424B-A187-1B295D2B3CBC"),
                        Name = "Deodorant (non-aerosol preferred)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("D07D2C78-ACBB-4D73-806D-1B5C67914554"),
                        Name = "Baby wipes",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("3186795C-EC04-4BF2-B31D-1D0CAF80CB24"),
                        Name = "Wide tooth comb",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("7FAB58DA-A415-40D1-8FD7-1DC1FCDBB729"),
                        Name = "Package of socks (size woman's)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("2FB04BE4-3B23-42EB-9534-20D767654667"),
                        Name = "Footed sleeper",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("A8AAE37C-E94B-4099-96A7-23BC27B9BDCE"),
                        Name = "Night light",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("E0F5C01D-A72A-4E59-ABBA-24C7309E9D37"),
                        Name = "Pillow case",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("4B223B2E-F4FE-4640-9DD0-2AA7F0263DEE"),
                        Name = "Sketch or composition book and pencils",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("E9800B98-0E56-4260-AE26-2E2939230C01"),
                        Name = "Twin blanket",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("BF225467-4B08-4DA0-A1E5-2EF0FF6E2F96"),
                        Name = "Diaper cream",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("618DBC0D-A9B0-4BE2-9A87-3442E309F746"),
                        Name = "Black hair care products (sulfate-free shampoo, leave-in conditioner, SheaMoisture, Cantu or Dream Kids brands)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("2BE28886-7E2E-41C6-886B-3A30EF4CF378"),
                        Name = "Baby lotion",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("C4878700-862C-4748-A0F5-43B1EF4D0655"),
                        Name = "Body lotion for sensitive skin (unscented)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("0C2C3738-E62E-4875-B786-46246636769B"),
                        Name = "Baby blanket or sleep sack",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("620B66ED-E341-4A14-B89C-48FD30632D5D"),
                        Name = "Bottles (for age 6+ months)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("44726539-9806-46A9-99B6-4BDB7DFD7363"),
                        Name = "Large throw",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("1AA58DA2-D195-4FFC-9BB7-51920EA8FDE4"),
                        Name = "Stuffed animal",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("F27211EE-28CB-42A1-B487-51AA7456CCD3"),
                        Name = "Socks",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("067AC574-C50A-4F2C-B8D7-52877EA217D4"),
                        Name = "Leak-proof water bottle",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("A809DFBA-5E21-491E-AB19-5374A141FE88"),
                        Name = "Board book",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("039C1F4E-7A2C-4B4A-9AEE-53F4957A7B01"),
                        Name = "Baby brush/comb",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("BF4A75E5-825C-4FED-A4C4-57EA77F21473"),
                        Name = "Package of socks (size youth medium)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("51D50F02-B916-4824-A9F0-59008D6BB8F8"),
                        Name = "Soft throw",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("BB8F1F6E-57D7-4537-8B66-59AA04728ADD"),
                        Name = "Gentle body wash (unscented)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("FCEEF0F8-C4D3-4BA3-BA6B-5C3288D794B2"),
                        Name = "Coloring book and washable crayons",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("0DDA4F68-ADC2-4136-B8CD-5EFFF84AE6CE"),
                        Name = "Satin bonnet or hair scarf",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("CDFC6B7F-31FB-4BD1-A246-6B8EFC241DFF"),
                        Name = "Baby lotion for sensitive skin",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("D2D503A2-F55C-4F44-87E1-6C4464A5F16B"),
                        Name = "Infant toy or stuffed animal (6+ months)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("802350C7-E12B-4AC2-A57E-6F394D67CC0C"),
                        Name = "Nerf or stress ball",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("86921BFC-74E7-47F8-A3EB-72928E5E2A8C"),
                        Name = "Shampoo/Conditioner 2-in-1",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("17D0900F-C48D-4059-8CAA-7697AF8EFBE0"),
                        Name = "Twin sheet set",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("027EA222-F944-41B8-8DEA-7F922C43C8A3"),
                        Name = "Body lotion",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("DD47744E-3EB3-4CDC-A697-8A707BF8AB3C"),
                        Name = "Package of socks (size men's)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("B43B17B3-B34D-4EFB-A07E-8C00E6E7AAB0"),
                        Name = "Crib sheet",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("B396C541-FFC3-4231-86FB-8CFED6EAE3A4"),
                        Name = "Gift card for diapers (Walmart/Target/Amazon)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("D69FEEE3-F0AE-456B-B000-9B8FB301DAD2"),
                        Name = "Soft throw (crib/toddler sized)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("9441220A-15EA-40E5-B452-9D5406794978"),
                        Name = "Hair brush",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("280A00C3-05B5-415E-876D-9E74D723B175"),
                        Name = "Bar soap",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("B8409915-46FB-408B-9070-A1BC72240000"),
                        Name = "Baby bottle (for ages 12+ months)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("65D5CA12-DE4B-4F4B-B57B-A28F14F4FD42"),
                        Name = "Toothbrush and toothpaste",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("7665E398-50B4-4E36-A8FC-A6368F192946"),
                        Name = "Body wash or bar soap",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("EC00957F-AA3B-4C34-8554-AA2AAF10335F"),
                        Name = "Package of diapers (size NB, 1, or 2)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("2FCBD4E6-479F-4C55-858E-AC69AEAB01B1"),
                        Name = "Toddler toothbrush and toothpaste (fluoride-free)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("4EDACB15-8C72-4361-911E-ADD9C1EF26AF"),
                        Name = "Water bottle",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("377311F0-F434-46C1-AC21-B05B82413E41"),
                        Name = "Composition book and pens",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("D8AC84A3-AFFF-485B-8949-B0C2C6272E85"),
                        Name = "Flashlight",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("D11D87E7-126C-4A3C-8125-B6A656D64FCC"),
                        Name = "Pacifier (newborn/up to 6 months)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("D5F318F9-D031-416F-B61D-BFF6EB3DDC21"),
                        Name = "Pillow",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("D0083F7A-CF78-4223-8328-C5FCAC9A8639"),
                        Name = "Body lotion (unscented: Jergens, Vaseline with Cocoa or Shea butter)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("4A7C2D02-C39A-48C9-9E81-C6198F87A2ED"),
                        Name = "Head-to-toe body wash",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("18B0B2A3-3163-463D-B8A1-C6314AEE6766"),
                        Name = "Detangling comb",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("3C7975D7-283F-4876-BF2C-C6C4A885D6CA"),
                        Name = "Aluminum-free deodorant",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("DFA15E75-56E9-4FD9-8ABE-C7CE9C28A6D8"),
                        Name = "Clear/invisible deodorant (non-aerosol preferred)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("483C2687-B6CC-4132-A386-C8351A3CE03C"),
                        Name = "Towel and wash cloth",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("305F2292-4230-403C-8E78-CCAB2B7FAF66"),
                        Name = "Pacifier (for age 6+ months)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("B0A6921D-55FD-40FF-B7E4-CEF32E093C21"),
                        Name = "Pillow (travel or child sized)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("DCE8A93B-66C4-4D10-A5C5-D72AE5ADD07F"),
                        Name = "Package of socks (size youth large)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("65EA10FE-B443-4233-A48A-D8BD7896D244"),
                        Name = "Swaddle wrap",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("E90C0353-DD59-4A87-9897-DA2BA2070999"),
                        Name = "Conditioner",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("70FEAB08-D33A-409B-AF35-DEE1C37FE46B"),
                        Name = "Shampoo",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("726CCF14-58B8-4878-B3EA-E58504BB71B3"),
                        Name = "Deodorant",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("BADAFEE8-1C62-46BE-98C9-E83C89F06322"),
                        Name = "Package of socks",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("61DA1441-6B0E-4D1A-88A2-EC632D01906D"),
                        Name = "Gentle baby wash and shampoo (sulfate-free)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("C915D086-E1CB-4A9C-A8F4-EF7D6331EB1D"),
                        Name = "Plastic hair pick",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("7AC8C99F-AACA-4883-AB1F-FB94FBAA9FCA"),
                        Name = "Anti-colic bottles",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Category
                    {
                        CategoryId = new Guid("B2488733-9E8D-47A5-B1A4-FE6FFE3DA0D5"),
                        Name = "Kids 3-in-1 soap (shampoo/conditioner/body wash)",
                        Active = true,
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        ProductId = new Guid("a4913d87-9305-4a4f-981f-09b0a226f753"),
                        Name = "Pampers Baby Dry Diapers Size 1 (8-14 lb), 44 Count",
                        Description = "Pampers baby-dry leakproof day & night diapers, size 1 (8-14 lb), 44 count, unisex.",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 9.97m,
                        Quantity = 1,
                        SafeStockLevel = 5,
                        Active = true,
                        CategoryId = new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("3e2d5eee-ebfc-4a86-9c9c-18049eccaeed"),
                        Name = "Orthodontic Pacifiers (2 pk, girl, 0-2 month)",
                        Description = "NUK newborn orthodontic pacifiers, girl, 0-2 months, 2-pack.",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 6.77m,
                        Quantity = 4,
                        SafeStockLevel = 4,
                        Active = true,
                        CategoryId = new Guid("d11d87e7-126c-4a3c-8125-b6a656d64fcc"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("dd6d4bec-20f1-4149-8f14-2141bad77e9b"),
                        Name = "The Very Hungry Caterpillar (board book)",
                        Description = "The Very Hungry Caterpillar, Board Book, English, 0-3 yrs, Infant-Toddler",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 8.78m,
                        Quantity = 2,
                        SafeStockLevel = 3,
                        Active = true,
                        CategoryId = new Guid("a809dfba-5e21-491e-ab19-5374a141fe88"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("d5b42185-f6f5-4d33-9c7d-392eadb5b1e6"),
                        Name = "Baby Cotton Swaddle Blankets (0-3 months, 3-pk)",
                        Description = "Gilquen baby organic cotton swaddle blankets for 0-3 months infant boys girls, adjustable newborn swaddles, 3-pack wrap set, twinkle & rainbow.",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 18.76m,
                        Quantity = 1,
                        SafeStockLevel = 2,
                        Active = true,
                        CategoryId = new Guid("65ea10fe-b443-4233-a48a-d8bd7896d244"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("9e0ef560-c184-46bb-9f57-45e295bf57b2"),
                        Name = "Huggies Baby Wipes (scented, 3 pk, 168 ct)",
                        Description = "Huggies natural care refreshing baby wipes, scented, (3 pk, 168 ct)",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 6.77m,
                        Quantity = 5,
                        SafeStockLevel = 3,
                        Active = true,
                        CategoryId = new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("06f703f4-dfbf-4fd0-b0a6-5c75bc8fe17a"),
                        Name = "Koala Baby Footed Sleeper (girl, 2 pk, NB-6M)",
                        Description = "Koala baby girls' newborn blanket sleeper, 2 pack, take me home sleep n play pajamas (Newborn-6M)",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 10.58m,
                        Quantity = 2,
                        SafeStockLevel = 5,
                        Active = true,
                        CategoryId = new Guid("2fb04be4-3b23-42eb-9534-20d767654667"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("16f0b155-8127-4eab-99e1-65473bc89952"),
                        Name = "Gentle Baby Wash & Shampoo (tear-free, sulfate-free, hypoallergenic, 27.1 fl oz)",
                        Description = "Johnson's head-to-toe gentle baby wash & shampoo, tear-free, sulfate-free & hypoallergenic wash for baby's sensitive skin & hair, 27.1 fl. oz.",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 11.95m,
                        Quantity = 1,
                        SafeStockLevel = 3,
                        Active = true,
                        CategoryId = new Guid("61da1441-6b0e-4d1a-88a2-ec632d01906d"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("1ec27cd4-58a3-49d3-8395-8d83536a4305"),
                        Name = "Desitin Diaper Cream (4 oz)",
                        Description = "Desitin maximum strength baby diaper rash cream with zinc oxide, 4 oz",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 7.78m,
                        Quantity = 3,
                        SafeStockLevel = 6,
                        Active = true,
                        CategoryId = new Guid("bf225467-4b08-4da0-a1e5-2ef0ff6e2f96"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("5aa553c8-f564-4755-9d2a-8e5a66f884d1"),
                        Name = "Aveeno Baby Daily Moisture Body Lotion (sensitive skin, 18 FL oz)",
                        Description = "Aveeno baby daily moisture body lotion for sensitive skin with natural colloidal oatmeal, suitable  for newborns, 18 FL oz",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 11.38m,
                        Quantity = 4,
                        SafeStockLevel = 3,
                        Active = true,
                        CategoryId = new Guid("cdfc6b7f-31fb-4bd1-a246-6b8efc241dff"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("331d83d3-04e4-41ca-9527-8ebcc1316090"),
                        Name = "Pampers Baby Wipes (sensitive, 8 pk, 672 wipes)",
                        Description = "Pampers sensitive baby wipes, 8 flip-top packs, 672 wipes",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 23.47m,
                        Quantity = 4,
                        SafeStockLevel = 3,
                        Active = true,
                        CategoryId = new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("6d59f00f-d7d8-48e3-ab36-9d96de8b09d0"),
                        Name = "Anti-colic Baby Bottles (blue, 3 pk, 5 oz)",
                        Description = "NUK smooth flow pro anti-colic baby bottle, 5 oz, blue, 3-pack",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 14.97m,
                        Quantity = 1,
                        SafeStockLevel = 3,
                        Active = true,
                        CategoryId = new Guid("7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("7604aea7-96b0-4096-8bbb-bbef00fdc221"),
                        Name = "Pampers Diapers (NB, 31 count)",
                        Description = "Pampers swaddlers diapers, newborn (< 10 lb), 31 count, unisex",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 14.5m,
                        Quantity = 4,
                        SafeStockLevel = 3,
                        Active = true,
                        CategoryId = new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("a864cd79-d226-441d-9f23-db77c2b9bd85"),
                        Name = "Foot Finder Socks & Wrist Rattles (NB, toys, 4 pcs)",
                        Description = "Amerteer 4 pcs foot finder socks & wrist rattles - newborn toys for baby boy or girl - brain development infant toys - hand and foot rattles suitable for 0-3, 3-6, 6-12 month babies.",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 7.28m,
                        Quantity = 3,
                        SafeStockLevel = 3,
                        Active = true,
                        CategoryId = new Guid("c50504d5-a7ec-4aab-acae-0ed0a39d1578"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("07979a90-bab9-47cf-befd-f0b16999ee00"),
                        Name = "Baby socks (unisex, 4 pk, newborn, 0-6 months)",
                        Description = "Gerber baby boy and girl unisex terry bootie wiggle-proof socks, 4-pack, newborn, 0-6 months.",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 4.00m,
                        Quantity = 1,
                        SafeStockLevel = 4,
                        Active = true,
                        CategoryId = new Guid("f27211ee-28cb-42a1-b487-51aa7456ccd3"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = new Guid("3a13f50b-b57f-44ae-ba14-f65e4e27cd54"),
                        Name = "Pampers Baby Dry Diapers Size 2 (12-18 lb), 37 Count",
                        Description = "Pampers baby-dry leakproof day & night diapers, size 2 (12-18 lb), 37 count, unisex.",
                        Expires = false,
                        PurchaseDate = DateTime.Now,
                        Price = 9.97m,
                        Quantity = 1,
                        SafeStockLevel = 5,
                        Active = true,
                        CategoryId = new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"),
                        LastUpdateId = "travis@mailsac.com",
                        LastUpdateDateTime = DateTime.Now
                    }
                );
        }
    }
}
