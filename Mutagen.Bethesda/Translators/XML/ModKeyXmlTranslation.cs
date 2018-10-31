﻿using Loqui.Internal;
using Loqui.Xml;
using Noggog.Notifying;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mutagen.Bethesda
{
    public class ModKeyXmlTranslation : IXmlTranslation<ModKey>
    {
        public readonly static ModKeyXmlTranslation Instance = new ModKeyXmlTranslation();

        public string ElementName => "ModKey";

        public bool Parse(XElement root, out ModKey item, ErrorMaskBuilder errorMask)
        {
            if (!StringXmlTranslation.Instance.Parse(root, out var str, errorMask))
            {
                item = default;
                return false;
            }

            return ModKey.TryFactory(str, out item);
        }

        public bool Parse(XElement root, out ModKey item, ErrorMaskBuilder errorMask, TranslationCrystal translationMask)
        {
            if (!StringXmlTranslation.Instance.Parse(root, out var str, errorMask, translationMask))
            {
                item = default;
                return false;
            }

            return ModKey.TryFactory(str, out item);
        }

        public void Write(XElement node, string name, ModKey item, ErrorMaskBuilder errorMask, TranslationCrystal translationMask)
        {
            StringXmlTranslation.Instance.Write(
                node,
                name,
                item.ToString(),
                errorMask);
        }

        public void Write(
            XElement node,
            string name,
            ModKey item,
            int fieldIndex,
            ErrorMaskBuilder errorMask)
        {
            try
            {
                errorMask?.PushIndex(fieldIndex);
                this.Write(
                    node: node,
                    name: name,
                    item: item,
                    errorMask: errorMask,
                    translationMask: null);
            }
            catch (Exception ex)
            when (errorMask != null)
            {
                errorMask.ReportException(ex);
            }
            finally
            {
                errorMask?.PopIndex();
            }
        }

        public void Write(
            XElement node,
            string name,
            IHasBeenSetItem<ModKey> item,
            int fieldIndex,
            ErrorMaskBuilder errorMask)
        {
            if (!item.HasBeenSet) return;
            this.Write(
                node: node,
                name: name,
                item: item.Item,
                errorMask: errorMask,
                fieldIndex: fieldIndex);
        }
    }
}
