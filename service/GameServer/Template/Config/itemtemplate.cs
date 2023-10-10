using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.Template.Config
{
    internal enum ItemType
    {
        ITEMTYPE_MISC,
        ITEMTYPE_USABLE,
        ITEMTYPE_RECOVER,
        ITEMTYPE_DEPOSIT,
        ITEMTYPE_SOUL,
        ITEMTYPE_MATERIAL,
        ITEMTYPE_RUNE,
        ITEMTYPE_SPELLBOOK,
        ITEMTYPE_FORMULA,
        ITEMTYPE_QUEST,
        ITEMTYPE_CHAOS_STONE,
        ITEMTYPE_MAGIC_SOUL,
        ITEMTYPE_EQUIP,
    }

    internal enum ItemSubType
    {
        ITEMSUBTYPE_MISC_DEFAULT,
        ITEMSUBTYPE_USABLE_POTION,
        ITEMSUBTYPE_USABLE_MISC,
        ITEMSUBTYPE_RECOVER_HP,
        ITEMSUBTYPE_RECOVER_MP,
        ITEMSUBTYPE_RECOVER_HPMP,
        ITEMSUBTYPE_DEPOSIT_SOUL,
        ITEMSUBTYPE_DEPOSIT_EXP,
        ITEMSUBTYPE_SOUL_DEFAULT,
        ITEMSUBTYPE_MATERIAL_REFINE,
        ITEMSUBTYPE_RUNE_DEFAULT,
        ITEMSUBTYPE_MATERIAL_COMPOSE,
        ITEMSUBTYPE_SPELLBOOK_PLAYER,
        ITEMSUBTYPE_FORMULA_DEFAULT,
        ITEMSUBTYPE_QUEST_DEFAULT,
        ITEMSUBTYPE_USABLE_GREY_POWDER,
        ITEMSUBTYPE_USABLE_RUNE,
        ITEMSUBTYPE_USABLE_QUIVER,
        ITEMSUBTYPE_MISC_INTERFACE,
        ITEMSUBTYPE_MATERIAL_WEAPON_LEVELUP,
        ITEMSUBTYPE_MATERIAL_MISC,
        ITEMSUBTYPE_QUEST_UNIDENTIFIED_CHAOS_STONE,
        ITEMSUBTYPE_CHAOS_STONE_DEFAULT,
        ITEMSUBTYPE_MAGIC_SOUL_ZUMA,
        ITEMSUBTYPE_EQUIP_WEAPON,
        ITEMSUBTYPE_EQUIP_CHEST_ARMOR,
        ITEMSUBTYPE_EQUIP_CLOAK,
        ITEMSUBTYPE_EQUIP_BELT,
        ITEMSUBTYPE_EQUIP_SHOES,
        ITEMSUBTYPE_EQUIP_NECKLACE,
        ITEMSUBTYPE_EQUIP_RING,
        ITEMSUBTYPE_EQUIP_BRACELET,
        ITEMSUBTYPE_EQUIP_SHOULDER_ARMOR,
        ITEMSUBTYPE_EQUIP_WRIST_ARMOR,
        ITEMSUBTYPE_EQUIP_HAT,
        ITEMSUBTYPE_EQUIP_HONOR,
        ITEMSUBTYPE_EQUIP_JADE,
        ITEMSUBTYPE_EQUIP_OFFHAND,
    }

    /// <summary>
    /// 物品列表
    /// </summary>
    internal class Itemtemplate : TemplateInterface
    {
        public int TemplateLevel => 51;

        public string TemplateName => "物品列表";

        public string TemplateDescription => "物品列表";

        public bool ReaderTemplate()
        {
            throw new NotImplementedException();
        }
    }
}
