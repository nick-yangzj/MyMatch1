----------------------------------------------------------------
--此文件是由ExcelConverter(1.0.0.6)工具自动导出，请勿手动修改
----------------------------------------------------------------

local data = { }

data.Tutorial = {
	id = {10001.000000, 10002.000000, 10003.000000, 10004.000000, 10005.000000, 10006.000000, 10007.000000, 10008.000000, 10009.000000},
	name = {"新手第一关引导", "新手第二关引导", "新手第二关触发特效引导", "新手第3关直角消引导", "新手第3关特效引爆引导", "新手第3关技能释放引导", "新手第四关特效交换引导", "新手第四关技能介绍引导", "新手第五关能量块引导"},
	scene_index = {2.000000, 2.000000, 2.000000, 2.000000, 2.000000, 2.000000, 2.000000, 2.000000, 2.000000},
	level_id = {1.000000, 2.000000, 2.000000, 3.000000, 3.000000, 3.000000, 4.000000, 4.000000, 5.000000},
	condition = {0.000000, 0.000000, 4.000000, 0.000000, 5.000000, 8.000000, 0.000000, 8.000000, 0.000000},
	condition_operator = {0.000000, 0.000000, 0.000000, 0.000000, 0.000000, 0.000000, 0.000000, 0.000000, 0.000000},
	condition_value = {0.000000, 0.000000, 0.000000, 0.000000, 0.000000, 0.000000, 0.000000, 0.000000, 0.000000},
	execute_times = {2.000000, 2.000000, 1.000000, 2.000000, 1.000000, 1.000000, 2.000000, 1.000000, 2.000000},
	after_execute = {1.000000, 1.000000, 1.000000, 1.000000, 1.000000, 1.000000, 1.000000, 1.000000, 1.000000},
	next_step = {0.000000, 0.000000, 0.000000, 0.000000, 0.000000, 0.000000, 0.000000, 0.000000, 0.000000},
	sound = {"aaa", "aaa", "aaa", "aaa", "aaa", "aaa", "aaa", "aaa", "aaa"},
	script = {"//进入游戏\nShowMaskA(0.7)\n$敌方BOSS = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Enemy\")\nShowTipEx($敌方BOSS,1,\"[280A0A]欢迎来到我的三消！@@快开始欢乐旅程吧！[-]\",-10,-200,380,240)\nWaitClick()\nHideTip()\n$方块1 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_4x4\")\n$方块2 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_3x3\")\n$方块3 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_4x3\")\n$方块4 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_5x3\")\nSetLayer($敌方BOSS)\nSetLayer($方块1)\nSetLayer($方块2)\nSetLayer($方块3)\nSetLayer($方块4)\nShowPointer($方块1,2)\nShowTip($方块1,2,\"[280A0A]连线[-][AC2020]三个相同[-][280A0A]小动物@@发动攻击！@@击败敌人！[-]\")\nWaitDragSuccess($方块1)\nResetLayer($敌方BOSS)\nResetLayer($方块1)\nResetLayer($方块2)\nResetLayer($方块3)\nResetLayer($方块4)\nHidePointer()\nHideTip()\nHideMask()", "//进入游戏\nShowMaskA(0.7)\n$方块1 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_0x7\")\n$方块2 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_1x7\")\n$方块3 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_2x7\")\n$方块4 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_3x7\")\n$方块6 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_2x6\")\nSetLayer($方块1)\nSetLayer($方块2)\nSetLayer($方块3)\nSetLayer($方块4)\nSetLayer($方块6)\nShowPointer($方块6,3)\nShowTip($方块6,2,\"[280A0A]连线[-][AC2020]四个相同[-][280A0A]小动物@@有特殊道具出现喔！[-]\")\nWaitDragSuccess($方块6)\nResetLayer($方块1)\nResetLayer($方块2)\nResetLayer($方块3)\nResetLayer($方块4)\nResetLayer($方块6)\nHidePointer()\nHideTip()\nHideMask()", "//进入游戏\nShowMaskA(0.7)\n$四消特效 = GetDefaultObject()\nSetLayer($四消特效)\nShowPointer($四消特效,2)\nShowTip($四消特效,2,\"[280A0A]快把[-][AC2020]特殊道具[-][280A0A]小苍蝇[-][AC2020]@@向您的BOSS方向[-][280A0A]滑动@@！！！！！[-]\")\nWaitDragSuccess($四消特效)\nResetLayer($四消特效)\nHidePointer()\nHideTip()\nHideMask()", "//进入游戏\nShowMaskA(0.7)\n$方块1 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_2x8\")\n$方块2 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_2x7\")\n$方块3 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_2x6\")\n$方块4 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_2x5\")\n$方块5 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_3x7\")\n$方块6 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_4x7\")\nSetLayer($方块1)\nSetLayer($方块2)\nSetLayer($方块3)\nSetLayer($方块4)\nSetLayer($方块5)\nSetLayer($方块6)\nShowPointer($方块1,2)\nShowTip($方块1,2,\"[280A0A]拖动小动物！@@形成[-][AC2020]直角消除！[-]\")\nWaitDragSuccess($方块1)\nResetLayer($方块1)\nResetLayer($方块2)\nResetLayer($方块3)\nResetLayer($方块4)\nResetLayer($方块5)\nResetLayer($方块6)\nHidePointer()\nHideTip()\nHideMask()", "//进入游戏\nShowMaskA(0.7)\n$五消特效 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_2x1\")\n$直角消特效 = GetDefaultObject()\nSetLayer($直角消特效)\nSetLayer($五消特效)\nShowPointer($直角消特效,2)\nShowTipEx($五消特效,2,\"[280A0A]快把特殊道具小飞龙@@向骑士方向滑动@@成功后会[-][AC2020]给BOSS加能量喔[-]\",0,400,380,240)\nWaitDragSuccess($直角消特效)\nResetLayer($直角消特效)\nResetLayer($五消特效)\nHidePointer()\nHideTip()\nHideMask()", "//进入游戏\nShowMaskA(0.7)\n$敌方BOSS = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Enemy/BingFa(Clone)\")\n$己方BOSS底座 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Fight_BossPos\")\n$己方BOSS = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/BossPos\")\nSetLayer($己方BOSS)\nSetLayer($己方BOSS底座)\nShowPointer($己方BOSS底座,4)\nShowTipEx($敌方BOSS,2,\"[280A0A]刚才的攻击@@使BOSS的能量增长了@@点击BOSS[-][AC2020]释放技能！[-]\",0,300,380,240)\nWaitClick($己方BOSS底座)\nResetLayer($己方BOSS)\nResetLayer($己方BOSS底座)\nHidePointer()\nHideTip()\nHideMask()\nShowMaskA(0.1)\nWaitGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Fight_BossPos/Skill/SkillBtn1/SkillBtn\")\n$大火球 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Fight_BossPos/Skill/SkillBtn1/SkillBtn\")\nSetLayer($大火球)\nShowPointer($大火球,5)\nShowTipEx($敌方BOSS,2,\"[280A0A]点击技能[-][AC2020]大火球[-][280A0A]@@释放！@@对敌人造成直接伤害！[-]\",0,150,380,240)\nWaitClick($大火球)\nResetLayer($大火球)\nHidePointer()\nHideTip()\nHideMask()", "//进入游戏\nShowMaskA(0.7)\n$五消特效 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_3x6\")\n$直角消特效 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_3x5\")\nSetLayer($五消特效)\nSetLayer($直角消特效)\nShowPointer($五消特效,2)\nShowTip($五消特效,2,\"[AC2020]两个相邻[-][280A0A]的@@特殊消除块交换@@会产生意想不到的@@效果喔！[-]\")\nWaitDragSuccess($五消特效)\nResetLayer($五消特效)\nResetLayer($直角消特效)\nHidePointer()\nHideTip()\nHideMask()", "//进入游戏\nShowMaskA(0.7)\n$敌方BOSS = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Enemy/BingFa(Clone)\")\n$己方BOSS底座 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Fight_BossPos\")\n$己方BOSS = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/BossPos\")\nSetLayer($己方BOSS)\nSetLayer($己方BOSS底座)\nShowPointer($己方BOSS底座,4)\nShowTipEx($敌方BOSS,2,\"[280A0A]BOSS的能量又涨了！@@这次我们来看下@@其他三个技能的用处！[-]\",0,300,380,240)\nWaitClick($己方BOSS底座)\nResetLayer($己方BOSS)\nResetLayer($己方BOSS底座)\nHidePointer()\nHideTip()\nHideMask()\nShowMaskA(0.1)\nWaitGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Fight_BossPos/Skill/SkillBtn2/SkillBtn\")\n$冰封术 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Fight_BossPos/Skill/SkillBtn1/SkillBtn\")\nShowPointer($冰封术,6)\nShowTipEx($敌方BOSS,4,\"[AC2020]冰封术[-][280A0A]@@冰封敌人5秒@期间无法进行消除！[-]\",100,130,300,160)\nWaitClick()\nHidePointer()\nHideTip()\nWaitGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Fight_BossPos/Skill/SkillBtn3/SkillBtn\")\n$加步数 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Fight_BossPos/Skill/SkillBtn2/SkillBtn\")\nShowPointer($加步数,7)\nShowTipEx($敌方BOSS,4,\"[AC2020]步数回复[-][280A0A]@@给自己回复@3步消除步数！[-]\",-60,-320,300,160)\nWaitClick()\nHidePointer()\nHideTip()\nWaitGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Fight_BossPos/Skill/SkillBtn4/SkillBtn\")\n$障碍 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Fight_BossPos/Skill/SkillBtn3/SkillBtn\")\nShowPointer($障碍,8)\nShowTipEx($敌方BOSS,4,\"[AC2020]障碍[-][280A0A]@@对敌人随机区域@释放3个木块！[-]\",-230,130,300,160)\nWaitClick()\nHidePointer()\nHideTip()\nHideMask()", "//进入游戏\nShowMaskA(0.7)\n$能量块 = GetGameObject(\"/UI Root/Camera/UIContainer/MainUI/Fight/Slot/Slot_5x6/Stone\")\nSetLayer($能量块)\nShowPointer($能量块,4)\nShowTipEx($能量块,2,\"[280A0A]这就是传说中的[-][AC2020]能量块[-][280A0A]@@在它旁边正常消除@@就可以收集它！[-]\",0,-300,380,240)\nWaitClick()\nResetLayer($能量块)\nHidePointer()\nHideTip()\nHideMask()"}
}

return data