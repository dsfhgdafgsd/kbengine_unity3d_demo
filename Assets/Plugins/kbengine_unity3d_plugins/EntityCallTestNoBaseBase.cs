/*
	Generated by KBEngine!
	Please do not modify this file!
	
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/TestNoBase.def
	public class EntityBaseEntityCall_TestNoBaseBase : EntityCall
	{
		public UInt16 entityComponentPropertyID = 0;

		public EntityBaseEntityCall_TestNoBaseBase(UInt16 ecpID, Int32 eid) : base(eid, "TestNoBase")
		{
			entityComponentPropertyID = ecpID;
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_BASE;
		}

	}

	public class EntityCellEntityCall_TestNoBaseBase : EntityCall
	{
		public UInt16 entityComponentPropertyID = 0;

		public EntityCellEntityCall_TestNoBaseBase(UInt16 ecpID, Int32 eid) : base(eid, "TestNoBase")
		{
			entityComponentPropertyID = ecpID;
			className = "TestNoBase";
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_CELL;
		}

		public void hello(Int32 arg1)
		{
			Bundle pBundle = newCall("hello", entityComponentPropertyID);
			if(pBundle == null)
				return;

			bundle.writeInt32(arg1);
			sendCall(null);
		}

	}
	}

