﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Projet_Mines_Official
{
    class InitilializerLesDossierPermis
    {
        public static void InitilizerDossiers(Permis permis,int type)
        {
            int typePermis = type;
            Global.context.Elements_Dossiers.Where(ed=>ed.Type_PermisId==typePermis).ToList().ForEach(E =>
            {
                Global.context.Permis_ElementDossiers.Add(new Permis_ElementDossier()
                {
                    PermisId = permis.PermisId,
                    Element_DossierId = E.Element_DossierId,
                });
            });
            Global.context.SaveChanges();
        }
    }
}
