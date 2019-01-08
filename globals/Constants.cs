using GTANetworkAPI;
using System;

namespace MyCustomGamemode.globals
{
    public class Constants
    {
        // Gamemode version
        public const string GM_VERSION = "v1.1.0";

        public const int ENVIRONMENT_KILL = 65535;
        public const int ITEMS_PER_INVENTORY_PAGE = 16;
        public const decimal ITEMS_ROBBED_PER_TIME = 1.5m;
        public const int MAX_GARBAGE_ROUTES = 4;
        public const int TOTAL_COLOR_ELEMENTS = 3;
        public const int MAX_BANK_OPERATIONS = 25;
        public const int MAX_LICENSE_QUESTIONS = 3;
        public const int MAX_DRIVING_VEHICLE = 100;
        public const int REDUCTION_PER_KMS = 125;
        public const int MAX_THEFTS_IN_ROW = 4;
        public const int MAX_WEAPON_SPAWNS = 1;
        public const int MAX_PLAYERS = 1000;
        public const int MAX_CRATES_SPAWN = 12;
        public const int MAX_WEAPON_CHANCE = 1235;
        public const int MAX_AMMO_CHANCE = 500;
        public const float GAS_CAN_LITRES = 10.0f;
        public const float LEVEL_MULTIPLIER = 3.25f;
        public const int PAID_PER_LEVEL = 30;
        public const float HOUSE_SALE_STATE = 0.7f;
        public const int MAX_HEAD_OVERLAYS = 11;

        // Sex
        public const int SEX_NONE = -1;
        public const int SEX_MALE = 0;
        public const int SEX_FEMALE = 1;

        // Chat
        public const int CHAT_LENGTH = 85;
        public const int CHAT_RANGES = 5;

        // Jail types
        public const int JAIL_TYPE_IC = 1;
        public const int JAIL_TYPE_OOC = 2;

        // Administrative ranks
        public const int STAFF_NONE = 0;
        public const int STAFF_SUPPORT = 1;
        public const int STAFF_GAME_MASTER = 2;
        public const int STAFF_S_GAME_MASTER = 3;
        public const int STAFF_ADMIN = 4;

        // Actions
        public const int ACTION_LOAD = 0;
        public const int ACTION_SAVE = 1;
        public const int ACTION_RENAME = 2;
        public const int ACTION_DELETE = 3;
        public const int ACTION_ADD = 4;
        public const int ACTION_SMS = 5;

        // Business types
        public const int BUSINESS_TYPE_NONE = -1;
        public const int BUSINESS_TYPE_24_7 = 1;
        public const int BUSINESS_TYPE_ELECTRONICS = 2;
        public const int BUSINESS_TYPE_HARDWARE = 3;
        public const int BUSINESS_TYPE_CLOTHES = 4;
        public const int BUSINESS_TYPE_BAR = 5;
        public const int BUSINESS_TYPE_DISCO = 6;
        public const int BUSINESS_TYPE_AMMUNATION = 7;
        public const int BUSINESS_TYPE_WAREHOUSE = 8;
        public const int BUSINESS_TYPE_JEWELRY = 9;
        public const int BUSINESS_TYPE_PRIVATE_OFFICE = 10;
        public const int BUSINESS_TYPE_CLUBHOUSE = 11;
        public const int BUSINESS_TYPE_GAS_STATION = 12;
        public const int BUSINESS_TYPE_SLAUGHTERHOUSE = 13;
        public const int BUSINESS_TYPE_BARBER_SHOP = 14;
        public const int BUSINESS_TYPE_FACTORY = 15;
        public const int BUSINESS_TYPE_TORTURE_ROOM = 16;
        public const int BUSINESS_TYPE_GARAGE_LOW_END = 17;
        public const int BUSINESS_TYPE_WAREHOUSE_MEDIUM = 18;
        public const int BUSINESS_TYPE_SOCIAL_CLUB = 19;
        public const int BUSINESS_TYPE_MECHANIC = 20;
        public const int BUSINESS_TYPE_TATTOO_SHOP = 21;
        public const int BUSINESS_TYPE_BENNYS_WHORKSHOP = 22;
        public const int BUSINESS_TYPE_VANILLA = 23;
        public const int BUSINESS_TYPE_FISHING = 24;

        // Phone numbers
        public const int NUMBER_POLICE = 091;
        public const int NUMBER_EMERGENCY = 112;
        public const int NUMBER_NEWS = 114;
        public const int NUMBER_FASTFOOD = 115;
        public const int NUMBER_MECHANIC = 116;
        public const int NUMBER_TAXI = 555;

        // Parking types
        public const int PARKING_TYPE_PUBLIC = 0;
        public const int PARKING_TYPE_GARAGE = 1;
        public const int PARKING_TYPE_SCRAPYARD = 2;
        public const int PARKING_TYPE_DEPOSIT = 3;

        // Clothes bodyparts
        public const int CLOTHES_MASK = 1;
        public const int CLOTHES_TORSO = 3;
        public const int CLOTHES_LEGS = 4;
        public const int CLOTHES_BAGS = 5;
        public const int CLOTHES_FEET = 6;
        public const int CLOTHES_ACCESSORIES = 7;
        public const int CLOTHES_UNDERSHIRT = 8;
        public const int CLOTHES_TOPS = 11;

        // Tattoo zones
        public const int TATTOO_ZONE_TORSO = 0;
        public const int TATTOO_ZONE_HEAD = 1;
        public const int TATTOO_ZONE_LEFT_ARM = 2;
        public const int TATTOO_ZONE_RIGHT_ARM = 3;
        public const int TATTOO_ZONE_LEFT_LEG = 4;
        public const int TATTOO_ZONE_RIGHT_LEG = 5;

        // Accessory types
        public const int ACCESSORY_HATS = 0;
        public const int ACCESSORY_GLASSES = 1;
        public const int ACCESSORY_EARS = 2;

        // Vehicle components
        public const int VEHICLE_MOD_SPOILER = 0;
        public const int VEHICLE_MOD_FRONT_BUMPER = 1;
        public const int VEHICLE_MOD_REAR_BUMPER = 2;
        public const int VEHICLE_MOD_SIDE_SKIRT = 3;
        public const int VEHICLE_MOD_EXHAUST = 4;
        public const int VEHICLE_MOD_FRAME = 5;
        public const int VEHICLE_MOD_GRILLE = 6;
        public const int VEHICLE_MOD_HOOD = 7;
        public const int VEHICLE_MOD_FENDER = 8;
        public const int VEHICLE_MOD_RIGHT_FENDER = 9;
        public const int VEHICLE_MOD_ROOF = 10;
        public const int VEHICLE_MOD_ENGINE = 11;
        public const int VEHICLE_MOD_BRAKES = 12;
        public const int VEHICLE_MOD_TRANSMISSION = 13;
        public const int VEHICLE_MOD_HORN = 14;
        public const int VEHICLE_MOD_SUSPENSION = 15;
        public const int VEHICLE_MOD_ARMOR = 16;
        public const int VEHICLE_MOD_XENON = 22;
        public const int VEHICLE_MOD_FRONT_WHEELS = 23;
        public const int VEHICLE_MOD_BACK_WHEELS = 24;
        public const int VEHICLE_MOD_PLATE_HOLDERS = 25;
        public const int VEHICLE_MOD_TRIM_DESIGN = 27;
        public const int VEHICLE_MOD_ORNAMIENTS = 28;
        public const int VEHICLE_MOD_DIAL_DESIGN = 30;
        public const int VEHICLE_MOD_STEERING_WHEEL = 33;
        public const int VEHICLE_MOD_SHIFTER_LEAVERS = 34;
        public const int VEHICLE_MOD_PLAQUES = 35;
        public const int VEHICLE_MOD_HYDRAULICS = 38;
        public const int VEHICLE_MOD_LIVERY = 48;

        // Inventory targets
        public const int INVENTORY_TARGET_SELF = 0;
        public const int INVENTORY_TARGET_PLAYER = 1;
        public const int INVENTORY_TARGET_HOUSE = 2;
        public const int INVENTORY_TARGET_VEHICLE_TRUNK = 3;
        public const int INVENTORY_TARGET_VEHICLE_PLAYER = 4;

        // Item types
        public const int ITEM_TYPE_CONSUMABLE = 0;
        public const int ITEM_TYPE_EQUIPABLE = 1;
        public const int ITEM_TYPE_OPENABLE = 2;
        public const int ITEM_TYPE_WEAPON = 3;
        public const int ITEM_TYPE_AMMUNITION = 4;
        public const int ITEM_TYPE_MISC = 5;

        // Amount of items when container opened
        public const int ITEM_OPEN_BEER_AMOUNT = 6;

        // 24-7 items
        public const string ITEM_HASH_FRIES = "1443311452";
        public const string ITEM_HASH_HOTDOG = "2565741261";
        public const string ITEM_HASH_CHOCOLATE_BAR = "921283475";
        public const string ITEM_HASH_BURGER = "2240524752";
        public const string ITEM_HASH_SANDWICH = "3602873787";
        public const string ITEM_HASH_CANDY = "3310697493";

        public const string ITEM_HASH_CUP_JUICE = "3638960837";
        public const string ITEM_HASH_ENERGY_DRINK = "582043502";
        public const string ITEM_HASH_BOTTLE_WATER = "746336278";
        public const string ITEM_HASH_CUP_COFFEE = "3696781377";
        public const string ITEM_HASH_CAN_COLA = "1020618269";

        public const string ITEM_HASH_CUP_WINE = "2998419875";
        public const string ITEM_HASH_CUP_CHAMPANGE = "600913159";
        public const string ITEM_HASH_BOTTLE_BEER_PISSWASSER = "4016900153";
        public const string ITEM_HASH_BOTTLE_BEER_AM = "1350970027";
        public const string ITEM_HASH_PACK_BEER_AM = "4241316616";
        public const string ITEM_HASH_BOTTLE_COGNAC = "1404018125";
        public const string ITEM_HASH_BOTTLE_CAVA = "3846720762";

        public const string ITEM_HASH_CIGARRETES_PACK_OPEN = "1079465856";

        // Electronic items
        public const string ITEM_HASH_TELEPHONE = "2277609629";
        public const string ITEM_HASH_WALKIE = "1806057883";
        public const string ITEM_HASH_RADIO_CASSETTE = "1060029110";
        public const string ITEM_HASH_CAMERA = "680380202";

        // Ammunition items
        public const string ITEM_HASH_PISTOL_AMMO_CLIP = "PistolAmmo";
        public const string ITEM_HASH_MACHINEGUN_AMMO_CLIP = "SmgAmmo";
        public const string ITEM_HASH_ASSAULTRIFLE_AMMO_CLIP = "RifleAmmo";
        public const string ITEM_HASH_SNIPERRIFLE_AMMO_CLIP = "SniperAmmo";
        public const string ITEM_HASH_SHOTGUN_AMMO_CLIP = "ShotgunAmmo";

        // Stack of the guns
        public const Int32 STACK_PISTOL_CAPACITY = 32;
        public const Int32 STACK_MACHINEGUN_CAPACITY = 100;
        public const Int32 STACK_SHOTGUN_CAPACITY = 24;
        public const Int32 STACK_ASSAULTRIFLE_CAPACITY = 60;
        public const Int32 STACK_SNIPERRIFLE_CAPACITY = 8;

        // Miscelaneous items
        public const string ITEM_HASH_ID_CARD = "511938898";
        public const string ITEM_HASH_CUFFS = "1070220657";
        public const string ITEM_HASH_JERRYCAN = "1069395324";
        public const string ITEM_HASH_FISHING_ROD = "2384362703";
        public const string ITEM_HASH_STOLEN_OBJECTS = "Stolen";
        public const string ITEM_HASH_BUSINESS_PRODUCTS = "Products";
        public const string ITEM_HASH_BAIT = "Bait";
        public const string ITEM_HASH_FISH = "Fish";

        // Vehicle color types
        public const int VEHICLE_COLOR_TYPE_PREDEFINED = 0;
        public const int VEHICLE_COLOR_TYPE_CUSTOM = 1;

        // Vehicle types
        public const int VEHICLE_CLASS_COMPACTS = 0;
        public const int VEHICLE_CLASS_SEDANS = 1;
        public const int VEHICLE_CLASS_SUVS = 2;
        public const int VEHICLE_CLASS_COUPES = 3;
        public const int VEHICLE_CLASS_MUSCLE = 4;
        public const int VEHICLE_CLASS_SPORTS = 5;
        public const int VEHICLE_CLASS_CLASSICS = 6;
        public const int VEHICLE_CLASS_SUPER = 7;
        public const int VEHICLE_CLASS_MOTORCYCLES = 8;
        public const int VEHICLE_CLASS_OFFROAD = 9;
        public const int VEHICLE_CLASS_INDUSTRIAL = 10;
        public const int VEHICLE_CLASS_UTILITY = 11;
        public const int VEHICLE_CLASS_VANS = 12;
        public const int VEHICLE_CLASS_CYCLES = 13;
        public const int VEHICLE_CLASS_BOATS = 14;
        public const int VEHICLE_CLASS_HELICOPTERS = 15;
        public const int VEHICLE_CLASS_PLANES = 16;
        public const int VEHICLE_CLASS_SERVICE = 17;
        public const int VEHICLE_CLASS_EMERGENCY = 18;
        public const int VEHICLE_CLASS_MILITARY = 19;
        public const int VEHICLE_CLASS_COMMERCIAL = 20;
        public const int VEHICLE_CLASS_TRAINS = 21;

        // Tax percentage
        public const float TAXES_VEHICLE = 0.005f;
        public const float TAXES_HOUSE = 0.0015f;

        // Gargabe route money
        public const int MONEY_GARBAGE_ROUTE = 350;

        // Price in products
        public const int PRICE_VEHICLE_CHASSIS = 300;
        public const int PRICE_VEHICLE_DOORS = 60;
        public const int PRICE_VEHICLE_WINDOWS = 15;
        public const int PRICE_VEHICLE_TYRES = 10;
        public const int PRICE_BARBER_SHOP = 100;
        public const int PRICE_ANNOUNCEMENT = 500;
        public const int PRICE_DRIVING_THEORICAL = 200;
        public const int PRICE_DRIVING_PRACTICAL = 300;
        public const int PRICE_IDENTIFICATION = 500;
        public const int PRICE_MEDICAL_INSURANCE = 2000;
        public const int PRICE_TAXI_LICENSE = 5000;
        public const int PRICE_STOLEN = 20;
        public const int PRICE_PARKING_PUBLIC = 50;
        public const int PRICE_PARKING_DEPOSIT = 500;
        public const int PRICE_PIZZA = 20;
        public const int PRICE_HAMBURGER = 10;
        public const int PRICE_SANDWICH = 5;
        public const int PRICE_GAS = 1;
        public const int PRICE_FISH = 20;

        // Factions
        public const int FACTION_NONE = 0;
        public const int FACTION_POLICE = 1;
        public const int FACTION_EMERGENCY = 2;
        public const int FACTION_NEWS = 3;
        public const int FACTION_TOWNHALL = 4;
        public const int FACTION_DRIVING_SCHOOL = 5;
        public const int FACTION_TAXI_DRIVER = 6;
        public const int FACTION_ADMIN = 9;
        public const int LAST_STATE_FACTION = 10;
        public const int MAX_FACTION_VEHICLES = 100;

        // Jobs
        public const int JOB_NONE = 0;
        public const int JOB_FASTFOOD = 1;
        public const int JOB_THIEF = 2;
        public const int JOB_MECHANIC = 3;
        public const int JOB_GARBAGE = 4;
        public const int JOB_HOOKER = 5;
        public const int JOB_FISHERMAN = 6;
        public const int JOB_TAXI = 7;

        // Database stored items' place
        public const string ITEM_ENTITY_GROUND = "Ground";
        public const string ITEM_ENTITY_PLAYER = "Player";
        public const string ITEM_ENTITY_VEHICLE = "Vehicle";
        public const string ITEM_ENTITY_HOUSE = "House";
        public const string ITEM_ENTITY_WHEEL = "Wheel";
        public const string ITEM_ENTITY_LEFT_HAND = "Left hand";
        public const string ITEM_ENTITY_RIGHT_HAND = "Right hand";

        // Driving school's licenses
        public const int LICENSE_CAR = 0;
        public const int LICENSE_MOTORCYCLE = 1;
        public const int LICENSE_TAXI = 2;

        // Driving school exam type
        public const int CAR_DRIVING_THEORICAL = 1;
        public const int CAR_DRIVING_PRACTICE = 2;
        public const int MOTORCYCLE_DRIVING_THEORICAL = 3;
        public const int MOTORCYCLE_DRIVING_PRACTICE = 4;

        // Town hall formalities
        public const int TRAMITATE_IDENTIFICATION = 0;
        public const int TRAMITATE_MEDICAL_INSURANCE = 1;
        public const int TRAMITATE_TAXI_LICENSE = 2;
        public const int TRAMITATE_FINE_LIST = 3;

        // Bank operations
        public const int OPERATION_WITHDRAW = 1;
        public const int OPERATION_DEPOSIT = 2;
        public const int OPERATION_TRANSFER = 3;
        public const int OPERATION_BALANCE = 4;

        // House status
        public const int HOUSE_STATE_NONE = 0;
        public const int HOUSE_STATE_RENTABLE = 1;
        public const int HOUSE_STATE_BUYABLE = 2;

        // Police control's items
        public const int POLICE_DEPLOYABLE_CONE = 1245865676;
        public const int POLICE_DEPLOYABLE_BEACON = 93871477;
        public const int POLICE_DEPLOYABLE_BARRIER = -143315610;
        public const int POLICE_DEPLOYABLE_SPIKES = -874338148;

        // Chat message types
        public const int MESSAGE_TALK = 0;
        public const int MESSAGE_YELL = 1;
        public const int MESSAGE_WHISPER = 2;
        public const int MESSAGE_ME = 3;
        public const int MESSAGE_DO = 4;
        public const int MESSAGE_OOC = 5;
        public const int MESSAGE_SU_TRUE = 6;
        public const int MESSAGE_SU_FALSE = 7;
        public const int MESSAGE_NEWS = 8;
        public const int MESSAGE_PHONE = 9;
        public const int MESSAGE_DISCONNECT = 10;
        public const int MESSAGE_MEGAPHONE = 11;
        public const int MESSAGE_RADIO = 12;

        // Chat colors
        public const string COLOR_CHAT_CLOSE = "!{#E6E6E6}";
        public const string COLOR_CHAT_NEAR = "!{#C8C8C8}";
        public const string COLOR_CHAT_MEDIUM = "!{#AAAAAA}";
        public const string COLOR_CHAT_FAR = "!{#8C8C8C}";
        public const string COLOR_CHAT_LIMIT = "!{#6E6E6E}";
        public const string COLOR_CHAT_ME = "!{#C2A2DA}";
        public const string COLOR_CHAT_DO = "!{#0F9622}";
        public const string COLOR_CHAT_FACTION = "!{#27F7C8}";
        public const string COLOR_CHAT_PHONE = "!{#27F7C8}";
        public const string COLOR_OOC_CLOSE = "!{#4C9E9E}";
        public const string COLOR_OOC_NEAR = "!{#438C8C}";
        public const string COLOR_OOC_MEDIUM = "!{#2E8787}";
        public const string COLOR_OOC_FAR = "!{#187373}";
        public const string COLOR_OOC_LIMIT = "!{#0A5555}";
        public const string COLOR_ADMIN_INFO = "!{#00FCFF}";
        public const string COLOR_ADMIN_NEWS = "!{#F93131}";
        public const string COLOR_ADMIN_MP = "!{#F93131}";
        public const string COLOR_SUCCESS = "!{#33B517}";
        public const string COLOR_ERROR = "!{#A80707}";
        public const string COLOR_INFO = "!{#FDFE8B}";
        public const string COLOR_HELP = "!{#FFFFFF}";
        public const string COLOR_SU_POSITIVE = "!{#E3E47D}";
        public const string COLOR_RADIO = "!{#1598C4}";
        public const string COLOR_RADIO_POLICE = "!{#4169E1}";
        public const string COLOR_RADIO_EMERGENCY = "!{#FF9F0F}";
        public const string COLOR_NEWS = "!{#805CC9}";
        public const string COLOR_PICKUP = "!{#FFFF00}";
        public const string PICKUP_MONEY_SECURITY_CASE = "{0xDE78F17E}";

        // Gargabe collector's routes
        public const int NORTH_ROUTE = 0;
        public const int EAST_ROUTE = 1;
        public const int SOUTH_ROUTE = 2;
        public const int WEST_ROUTE = 3;

        // Hooker's services
        public const int HOOKER_SERVICE_BASIC = 0;
        public const int HOOKER_SERVICE_FULL = 1;

        // Alcohol limit
        public const float WASTED_LEVEL = 0.4f;


       //Following function checks if player is in range of point. 

        public bool IsPlayerInRangeOf(Client client,Vector3 vector,float range)
        {
            Vector3 cPos = client.Position;
            Vector3 pPos = vector;
            if (rangex(cPos.X,pPos.X,range) && rangey(cPos.Y, pPos.Y, range) && rangez(cPos.Z, pPos.Z, range))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // FLOAT RANGERS
        public bool rangex(float x,float tx,float range)
        {
            if (x > tx && x < tx + range || x < tx && x > tx - range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool rangey(float x, float tx, float range)
        {
            if (x > tx && x < tx + range || x < tx && x > tx - range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool rangez(float x, float tx, float range)
        {
            if (x > tx && x < tx + range || x < tx && x > tx - range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

        public enum AnimationFlags
        {
            Loop = 1 << 0,
            StopOnLastFrame = 1 << 1,
            OnlyAnimateUpperBody = 1 << 4,
            AllowPlayerControl = 1 << 5,
            Cancellable = 1 << 7
        };
    }

