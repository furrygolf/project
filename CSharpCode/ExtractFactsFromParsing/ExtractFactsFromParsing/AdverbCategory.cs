﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class AdverbCategory
{
    static HashSet<string> adv_group1 = null;// влево
    static HashSet<string> adv_group2 = null; // внутри
    static HashSet<string> adv_group3 = null; // быстро
    static HashSet<string> adv_group4 = null; // всегда
    static HashSet<string> adv_group5 = null; // много

    public static string GetQuestionWordForAdverb(string a0)
    {
        string a = a0.ToLower();

        if (adv_group1 == null)
        {
            adv_group1 = new HashSet<string>();
            adv_group2 = new HashSet<string>();
            adv_group3 = new HashSet<string>();
            adv_group4 = new HashSet<string>();
            adv_group5 = new HashSet<string>(); // счетные наречия
            foreach (string w in "влево вправо вверх вниз домой наружу внутрь".Split())
            {
                adv_group1.Add(w);
            }

            foreach (string w in "внутри снаружи везде всюду сзади спереди сбоку сверху снизу там тут здесь повсюду повсеместно рядом неподалеку вдали".Split())
            {
                adv_group2.Add(w);
            }

            // КАК
            string how_list = "быстро медленно плохо хорошо шустро понарошку агрессивно " +
                "активно отдельно постоянно отлично индивидуально покорно удовлетворенно мрачно тяжело охотно весело " +
                "одобрительно удивленно презрительно небрежно коротко испуганно нерешительно неловко кокетливо " +
                "нехотя невесело осторожно угрюмо молча следом дипломатично моментально тихо звонко цинично учащенно лениво " +
                "сочувственно оживленно робко обиженно загадочно пьяно понуро беспомощно громко автоматически " +
                "отрывисто лукаво судорожно неумолимо робко звучно затравленно немедленно оскорбленно намертво насовсем " +
                "поспешно постепенно тихо смело постепенно мощно сиротливо устало неслышно наскоком недвижно монолитно монотонно " +
                "очумело пугливо сытно тоскливо сумрачно растерянно круто звонко резко успешно гулко невольно внимательно " +
                "отважно тяжело яростно задумчиво долго основательно прочно злобно вопрошающе пристально недоуменно неустанно " +
                "внакладе впритык нармонично туго красиво тайно навсегда победно сообща внезапно идеально нарасхват " +
                "виртуозно экстренно остро достойно неизменно наизнанку радушно единогласно честно порядочно неправильно " +
                "незначительно щедро изумленно обессилено непринужденно легко бесшумно неуклонно врасплох хмуро мягко " +
                "вежливо буквально укоризненно предупредительно больно обидно сердито скептически демонстративно незатейливо отчаянно " +
                "хладнокровно охотнее медленнее шустрее агрессивнее активнее ";
            foreach (string w in how_list.Split())
            {
                adv_group3.Add(w);
            }

            foreach (string w in "всегда сегодня вчера позавчера послезавтра ежедневно еженочно ежемесячно наутро поутру накануне".Split())
            {
                adv_group3.Add(w);
            }


            foreach (string w in "сколько много немного мало несколько".Split())
            {
                adv_group5.Add(w);
            }

        }

        if (adv_group1.Contains(a)) return "куда";
        if (adv_group2.Contains(a)) return "где";
        if (adv_group3.Contains(a)) return "как";
        if (adv_group4.Contains(a)) return "когда";
        if (adv_group5.Contains(a)) return "counter";

        return null;
    }
}
