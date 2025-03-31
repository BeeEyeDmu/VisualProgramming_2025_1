using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_Labels
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnRaffaello_Click(object sender, EventArgs e)
    {
      lblArtist.Text = "라파엘로 산치오 다 우르비노(1483년 4월 6일~1520년 4월 6일), 르네상스 시대 이탈리아의 예술가·화가";
      lblArt.Text = "《아테네 학당》(이탈리아어: Scuola di Atene)은 화가 라파엘로의 프레스코화로 1509 ~ 1511년에 바티칸 사도 궁전 내부의 방들 가운데 교황의 개인 서재인 서명의 방에 교황 율리오 2세를 위해 만들어졌다. 이 그림은 연작의 한 부분으로 《아테네 학당》 옆에는 《신성한 성단식의 논의》(성체논의, Disputa del Sacramento)와 추덕을 보여주는 파르나소스산을 표현했다. 그림의 제목은 고대 그리스의 뛰어난 철학적 사고 학당을 나타내고, 그들의 선구자, 주요 대표자 및 후계자를 구현해냈다. 중심에는 철학자 플라톤과 아리스토텔레스가 있다. 이 프레스코는 르네상스 정신 속에 유럽 문화, 그들의 철학 그리고 학문의 기원에 대한 고대 사상을 찬양한다.";
    }

    private void btnDavinch_Click(object sender, EventArgs e)
    {
      lblArtist.Text = "레오나르도 다 빈치(1452년 4월 15일~1519년 5월 2일), 이탈리아의 예술가로 이탈리아를 대표하는 석학(polymath)";
      lblArt.Text = "《모나리자》(영어: Mona Lisa)는 16세기 르네상스 시대에 레오나르도 다 빈치가 그린 초상화로, 현재 프랑스 파리 루브르 박물관에 전시되어 있다. \"모나\"(mona)는 유부녀 이름 앞에 붙이는 이탈리아어 경칭이고, \"리자\"(Lisa)는 초상화의 모델이 된 여인의 이름이다. 즉, 한국어로 하면 \"리자 여사\"라는 뜻이 된다. 이탈리아에서는 《조콘다》(이탈리아어: Gioconda)라 하는데 이는 \"조콘도의 부인\" 또는 \"명랑한 여자\", \"웃고 있는 여자\"라는 뜻이다.";
    }
  }
}
