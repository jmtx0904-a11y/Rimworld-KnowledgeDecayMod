using Verse;
using RimWorld;

namespace KnowledgeDecayMod
{
    public class KnowledgeDecayComp : ThingComp
    {
        public float knowledge = 1f; // 1 = 100% conocimiento

        public override void CompTick()
        {
            base.CompTick();

            // Solo cada 250 ticks (cada 4 segundos)
            if (Find.TickManager.TicksGame % 250 != 0)
                return;

            // Reduce el conocimiento
            knowledge -= 0.0005f;

            // Nunca menos de 0
            if (knowledge < 0f)
                knowledge = 0f;
        }

        public override string CompInspectStringExtra()
        {
            return "Conocimiento restante: " + (knowledge * 100f).ToString("0") + "%";
        }
    }
}
