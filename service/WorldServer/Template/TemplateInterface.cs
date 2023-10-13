namespace WorldServer.Template
{
    internal interface TemplateInterface
    {
        /// <summary>
        /// 优先级
        /// </summary>
        public int TemplateLevel { get; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public string TemplateName { get; }

        /// <summary>
        /// 模板说明
        /// </summary>
        public string TemplateDescription { get; }

        /// <summary>
        /// 读取模板
        /// </summary>
        /// <returns></returns>
        public bool ReaderTemplate();

        #region 基础编号

        public enum Template : int
        {
            /// <summary>
            /// 成就数据
            /// </summary>
            Achievementtemplate = 1,
            /// <summary>
            /// 活动数据
            /// </summary>
            Activitytemplate,
            /// <summary>
            /// 属性数据
            /// </summary>
            Attributetemplate,
            /// <summary>
            /// 形象数据
            /// </summary>
            Apperancetemplate,
            /// <summary>
            /// 灵石属性
            /// </summary>
            Soultemplate,
            /// <summary>
            /// 增长属性
            /// </summary>
            Growthtemplate,
            /// <summary>
            /// 宝箱数据
            /// </summary>
            Doodadtemplate,
            /// <summary>
            /// 宝箱掉落
            /// </summary>
            Doodaddroptemplate,
            /// <summary>
            /// 礼包数据
            /// </summary>
            Gift_detailtemplate,
            /// <summary>
            /// 称号
            /// </summary>
            Titletemplate,
            /// <summary>
            /// 坐骑数据
            /// </summary>
            Mounttemplate,
            /// <summary>
            /// 商城数据
            /// </summary>
            Realmoneyshoptemplate,
            /// <summary>
            /// 黑市商店
            /// </summary>
            Blackmarkettemplate,
            /// <summary>
            /// 初始数据
            /// </summary>
            Spirittemplate,
            /// <summary>
            /// 每周特惠
            /// </summary>
            Weeklytemplate,
            /// <summary>
            /// 月卡特权
            /// </summary>
            Monthlycardtemplate,
            /// <summary>
            /// 物品数据
            /// </summary>
            Itemtemplate = 51,
            /// <summary>
            /// 装备数据
            /// </summary>
            Item_armortemplate = 52,
            /// <summary>
            /// 怪物数据
            /// </summary>
            Npctemplate = 61,
            /// <summary>
            /// 怪物功能
            /// </summary>
            Handbooktemplate,
            /// <summary>
            /// 技能增益
            /// </summary>
            Auratemplate = 70,
            /// <summary>
            /// 洗练品质
            /// </summary>
            Runetemplate,
            /// <summary>
            /// 技能伤害
            /// </summary>
            Spell_vartemplate,
            /// <summary>
            /// 技能过程
            /// </summary>
            Spell_progresstemplate,
            /// <summary>
            /// 技能数据
            /// </summary>
            Spelltemplate,
            /// <summary>
            /// 任务数据
            /// </summary>
            Questtemplate = 80,
            /// <summary>
            /// 地图数据
            /// </summary>
            Scenetemplate = 91,
            /// <summary>
            /// 地形区域
            /// </summary>
            Regiontemplate = 92,
            /// <summary>
            /// 驿站传送
            /// </summary>
            Transfertemplate = 93,
            /// <summary>
            /// 阵法数据
            /// </summary>
            Transfertemplates,
            /// <summary>
            /// 怪物分布
            /// </summary>
            Distributiontemplates,
        }
        #endregion
    }
}
