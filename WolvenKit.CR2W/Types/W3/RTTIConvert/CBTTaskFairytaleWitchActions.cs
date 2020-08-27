using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFairytaleWitchActions : IBehTreeTask
	{
		[RED("action")] 		public CEnum<EFairytaleWitchAction> Action { get; set;}

		[RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		public CBTTaskFairytaleWitchActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFairytaleWitchActions(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}