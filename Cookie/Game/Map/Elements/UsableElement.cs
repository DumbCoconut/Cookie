﻿using System.Collections.Generic;
using Cookie.API.Game.Map.Elements;
using Cookie.API.Protocol.Network.Types.Game.Interactive;

namespace Cookie.Game.Map.Elements
{
    public class UsableElement : IUsableElement
    {
        public UsableElement(int cellId, IInteractiveElement element, List<InteractiveElementSkill> skills)
        {
            CellId = cellId;
            Element = element;
            Skills = skills;
        }

        public int CellId { get; private set; }
        public IInteractiveElement Element { get; private set; }
        public List<InteractiveElementSkill> Skills { get; private set; }
    }
}