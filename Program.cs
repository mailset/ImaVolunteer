/**
  * @Author :mail_set(郭子瑞)
  * @Class :7(16)
  * @Date :2022/11/13 19:40
  * @Intro :一个关于志愿者的小游戏，第一次做，请谅解QwQ
  */
using Sharprompt;
using System;
using System.Diagnostics;

namespace ImaVolunteer {
    /** Values In Game */
    class Values {
        public int gameScore = 0;
        public string sex = "";
        public string name = "";
        public string select = "";
        public int things = 0;
    }
    /** Main */
    class Program {
        static void Next() {
            Console.WriteLine("\n\n按任意键继续");
            Console.ReadLine();
            Console.Clear();
        }
        /** Intro */
        static void Intro() {
            Console.WriteLine("\t这是一个关于志愿者的小游戏，第一次制作，不太娴熟www\n");
            Console.WriteLine("如果您遇到什么问题，欢迎给我邮箱 m_s114514@outlook.com 非常谢谢！\n");
            Console.WriteLine("\t\t\t2022 mail_set(c) Copyright");
            Console.WriteLine("\n\n\n\n\t\t\t按任意键开始！");
            Console.ReadKey();
            Console.Clear();
        }
        /** Main */
        static void Main(string[] args) {
            /** Init */
            Values values = new Values();
            Intro();
            /** Input Name */
            values.name = Prompt.Input<string>("  新的一天到来了，您是一名志愿者，您的名字是？");
            Console.Clear();
            /** Input Sex */
            values.sex = Prompt.Select($" 您是一名叫{values.name}的志愿者，您的性别是？", new[] { "男", "女"});
            Console.Clear();
            /** Information */
            Console.WriteLine($"  您是一名{values.sex}志愿者，名字是{values.name}，您从床上爬起，要开始新一天的生活。");
            Next();
            /** Plot Start */
            Console.WriteLine("  您去到了楼下，走了一会儿发现有很多游走在法律边缘的小广告。");
            Next();
            /** 1st Plot */
            values.select = Prompt.Select("您怒火中烧，准备？", new[] { "铲掉，必须铲掉这些小广告！", "算了算了，还有人来管。" });
            /** JUSTICE Select */
            if (values.select == "铲掉，必须铲掉这些小广告！") {
                Console.Clear();
                Console.WriteLine("  您怒火中烧，拿起旁边的铲子，一铲铲掉了小广告，你心中充满了正义感。");
                values.gameScore += 30;
                values.things++;
                Next();
            }
            /** NOT Justice Select */
            else {
                Console.Clear();
                Console.WriteLine("  你怒火中烧，可是转念一想可能有人来管，又转身就走了。");
                Next();
            }
            /** 2st Plot */
            Console.WriteLine("  您走着走着，发现一个人遛狗不拴绳，并且旁边走着一位小女孩，看起来很害怕的样子。");
            Next();
            values.select = Prompt.Select("  您很是不解，准备？", new[] { "直接施行正义，制止那人！", "走了走了，不管我的事。" });
            /** JUSTICE Select */
            if(values.select == "直接施行正义，制止那人！") {
                Console.Clear();
                Console.WriteLine("  您很是不解，走上去处理了那个人，并让其他人把他带到了派出所，转过头来安抚了小女孩。心中充满了骄傲感。");
                values.gameScore += 30;
                values.things++;
                Next();
            }
            /** NOT Justice Select */
            else {
                Console.Clear();
                Console.WriteLine("  你很是不解，但突然觉得这三足鼎立的样子很好笑，便的走了");
                values.gameScore -= 10;
                Next();
            }
            /** Last Plot */
            Console.WriteLine("  您开始四处检查，发现有一伙人追踪着一个年轻的女孩子，蹑手蹑脚的。");
            Next();
            values.select = Prompt.Select("  您很是愤怒，准备？", new[] {"飞奔上前，把那伙人Knock了，直接送它们去看守所！（无慈悲）", "算了算了，吃瓜吃瓜OrO"});
            /** JUSTICE Select */
            if(values.select == "飞奔上前，把那伙人Knock了，直接送它们去看守所！（无慈悲）") {
                Console.Clear();
                Console.WriteLine("  您很是愤怒，对着那货人喊着：\"喂！你们别跑！\"接着一步冲上前，把他们擒拿在地。");
                Next();
                Console.WriteLine("  您虽然受了点伤，但是心中非常的开心。");
                values.gameScore += 40;
                values.things++;
                Next();
            }
            /** NOT Justice Select */
            else {
                Console.Clear();
                Console.WriteLine("  您很是愤怒，但是又不敢，就静静的站在那里看着他们，走到了一个隐蔽的角落。");
                Next();
                Console.WriteLine("  接着，你听到一个女生尖叫着说：\"你们干什么！不要！\"你心里未免有点唏嘘。");
                values.gameScore -= 20;
                Next();
            }
            /** Game Over */
            Console.WriteLine("  您作为志愿者的一天结束了。回家躺在了床上。");
            Next();
            switch (values.things) {
                case 0: Console.WriteLine("您今天心里未免有些失落，觉得心里空空的。");
                    break;
                case 1: Console.WriteLine("您今天总算是做了一件好事，心里也不太难受。");
                    break;
                case 2: Console.WriteLine("\"WOW，我今天做了两件好事欸！\"您心里想着，很充实。");
                    break;
                case 3: Console.WriteLine("您心中充满了正义感，非常的开心。安然的入睡了。");
                    break;
            }
            Next();
            /** Clearing */
            Console.WriteLine("  游戏结束！");
            Console.WriteLine($" 您的分数是：{values.gameScore}\n还干了{values.things}件好事。");
            values.select = Prompt.Select("您要再玩一遍吗？", new[] { "再玩一遍再玩一遍！", "不用了，我满足了www"});
            if(values.select == "再玩一遍再玩一遍！") {
                Console.Clear();
                Console.WriteLine("正在为您跳转~");
                values = null;
                Next();
                Main(null);
            } else {
                Console.Clear();
                Console.WriteLine("感谢您的游玩！\n\n2022 mail_set(c) Copyright.");
                Next();
            }
        }
    }
}