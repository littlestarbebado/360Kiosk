using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MonumentosUI : MonoBehaviour
{
    public enum Pais
    {
        Mexico,
        Marrocos,
        Brasil,
        AfricaDoSul,
        Italia,
        Fiji,
        Australia,
        Japao,
        India,
        Portugal
    }

    [System.Serializable]
    public class Monumento
    {
        public string nome;
        public Sprite imagem;

        [TextArea(2, 6)]
        public string descricao;

        public string localizacao;
    }

    [Header("Escolhe o país deste Canvas")]
    public Pais pais;

    [Header("Referências da UI")]
    public Image imageGrande;
    public TMP_Text descricaoTexto;
    public TMP_Text localizacaoTexto;

    [Header("Botões")]
    public Button botao1;
    public Button botao2;
    public Button botao3;

    [Header("Imagens do país selecionado")]
    public Sprite imagem1;
    public Sprite imagem2;
    public Sprite imagem3;

    private Monumento[] monumentos;

    void Start()
    {
        CriarDadosDoPais();

        if (botao1 != null)
        {
            botao1.onClick.RemoveAllListeners();
            botao1.onClick.AddListener(() => MostrarMonumento(0));
        }

        if (botao2 != null)
        {
            botao2.onClick.RemoveAllListeners();
            botao2.onClick.AddListener(() => MostrarMonumento(1));
        }

        if (botao3 != null)
        {
            botao3.onClick.RemoveAllListeners();
            botao3.onClick.AddListener(() => MostrarMonumento(2));
        }

        MostrarMonumento(0);
    }

    void CriarDadosDoPais()
    {
        monumentos = new Monumento[3];

        switch (pais)
        {
            case Pais.Mexico:
                monumentos[0] = new Monumento
                {
                    nome = "Chichén Itzá",
                    imagem = imagem1,
                    descricao = "Chichén Itzá é uma antiga cidade maia e uma das maravilhas do mundo moderno. A sua pirâmide é um dos monumentos mais famosos do México.",
                    localizacao = "Yucatán, México"
                };

                monumentos[1] = new Monumento
                {
                    nome = "Teotihuacan",
                    imagem = imagem2,
                    descricao = "Teotihuacan foi uma grande cidade da antiguidade. É conhecida pelas Pirâmides do Sol e da Lua.",
                    localizacao = "Estado do México, México"
                };

                monumentos[2] = new Monumento
                {
                    nome = "Palácio de Bellas Artes",
                    imagem = imagem3,
                    descricao = "O Palácio de Bellas Artes é um importante edifício cultural do México, famoso pela sua arquitetura e pelos seus espetáculos.",
                    localizacao = "Cidade do México, México"
                };
                break;

            case Pais.Marrocos:
                monumentos[0] = new Monumento
                {
                    nome = "Mesquita Hassan II",
                    imagem = imagem1,
                    descricao = "A Mesquita Hassan II é uma das maiores do mundo. Destaca-se pelo seu minarete alto e pela localização junto ao mar.",
                    localizacao = "Casablanca, Marrocos"
                };

                monumentos[1] = new Monumento
                {
                    nome = "Ait Benhaddou",
                    imagem = imagem2,
                    descricao = "Ait Benhaddou é uma aldeia fortificada tradicional feita de terra. É um importante património histórico de Marrocos.",
                    localizacao = "Ouarzazate, Marrocos"
                };

                monumentos[2] = new Monumento
                {
                    nome = "Medina de Fez",
                    imagem = imagem3,
                    descricao = "A Medina de Fez é uma das zonas medievais mais bem preservadas do mundo. As suas ruas mostram a tradição marroquina.",
                    localizacao = "Fez, Marrocos"
                };
                break;

            case Pais.Brasil:
                monumentos[0] = new Monumento
                {
                    nome = "Cristo Redentor",
                    imagem = imagem1,
                    descricao = "O Cristo Redentor é um dos símbolos mais conhecidos do Brasil. Fica no alto do Corcovado e domina a paisagem do Rio de Janeiro.",
                    localizacao = "Rio de Janeiro, Brasil"
                };

                monumentos[1] = new Monumento
                {
                    nome = "Catedral de Brasília",
                    imagem = imagem2,
                    descricao = "A Catedral de Brasília é famosa pela sua arquitetura moderna. O seu formato é um dos mais marcantes do país.",
                    localizacao = "Brasília, Brasil"
                };

                monumentos[2] = new Monumento
                {
                    nome = "Teatro Amazonas",
                    imagem = imagem3,
                    descricao = "O Teatro Amazonas é um edifício histórico muito importante. Foi construído durante o ciclo da borracha e é um símbolo de Manaus.",
                    localizacao = "Manaus, Brasil"
                };
                break;

            case Pais.AfricaDoSul:
                monumentos[0] = new Monumento
                {
                    nome = "Robben Island",
                    imagem = imagem1,
                    descricao = "Robben Island é conhecida por ter sido a prisão de Nelson Mandela. Hoje é um símbolo da luta contra o apartheid.",
                    localizacao = "Cidade do Cabo, África do Sul"
                };

                monumentos[1] = new Monumento
                {
                    nome = "Union Buildings",
                    imagem = imagem2,
                    descricao = "Os Union Buildings são a sede do governo sul-africano e representam um lugar importante na história do país.",
                    localizacao = "Pretória, África do Sul"
                };

                monumentos[2] = new Monumento
                {
                    nome = "Voortrekker Monument",
                    imagem = imagem3,
                    descricao = "O Voortrekker Monument é um monumento histórico importante que homenageia os pioneiros africâneres.",
                    localizacao = "Pretória, África do Sul"
                };
                break;

            case Pais.Italia:
                monumentos[0] = new Monumento
                {
                    nome = "Coliseu",
                    imagem = imagem1,
                    descricao = "O Coliseu é um dos monumentos mais famosos do mundo. Foi usado para espetáculos na Roma Antiga.",
                    localizacao = "Roma, Itália"
                };

                monumentos[1] = new Monumento
                {
                    nome = "Torre de Pisa",
                    imagem = imagem2,
                    descricao = "A Torre de Pisa é conhecida pela sua inclinação. É um dos símbolos mais famosos de Itália.",
                    localizacao = "Pisa, Itália"
                };

                monumentos[2] = new Monumento
                {
                    nome = "Basílica de São Pedro",
                    imagem = imagem3,
                    descricao = "A Basílica de São Pedro é uma das maiores igrejas do mundo e um importante centro religioso e artístico.",
                    localizacao = "Vaticano, Itália"
                };
                break;

            case Pais.Fiji:
                monumentos[0] = new Monumento
                {
                    nome = "Sri Siva Subramaniya Temple",
                    imagem = imagem1,
                    descricao = "Este templo é um dos monumentos religiosos mais conhecidos de Fiji. Destaca-se pelas suas cores e estilo indiano.",
                    localizacao = "Nadi, Fiji"
                };

                monumentos[1] = new Monumento
                {
                    nome = "Fiji Museum",
                    imagem = imagem2,
                    descricao = "O Fiji Museum apresenta a história e cultura das ilhas Fiji. É um local importante para conhecer o passado do país.",
                    localizacao = "Suva, Fiji"
                };

                monumentos[2] = new Monumento
                {
                    nome = "Garden of the Sleeping Giant",
                    imagem = imagem3,
                    descricao = "O Garden of the Sleeping Giant é conhecido pelas suas flores e paisagens naturais, sendo um local muito bonito e visitado.",
                    localizacao = "Nadi, Fiji"
                };
                break;

            case Pais.Australia:
                monumentos[0] = new Monumento
                {
                    nome = "Sydney Opera House",
                    imagem = imagem1,
                    descricao = "A Sydney Opera House é um dos edifícios mais famosos do mundo. O seu design faz lembrar velas de um barco.",
                    localizacao = "Sydney, Austrália"
                };

                monumentos[1] = new Monumento
                {
                    nome = "Sydney Harbour Bridge",
                    imagem = imagem2,
                    descricao = "A Sydney Harbour Bridge é uma grande ponte de aço e um dos marcos mais importantes da cidade de Sydney.",
                    localizacao = "Sydney, Austrália"
                };

                monumentos[2] = new Monumento
                {
                    nome = "Uluru",
                    imagem = imagem3,
                    descricao = "Uluru é uma formação rochosa sagrada para os povos aborígenes e um dos locais naturais mais conhecidos da Austrália.",
                    localizacao = "Território do Norte, Austrália"
                };
                break;

            case Pais.Japao:
                monumentos[0] = new Monumento
                {
                    nome = "Kinkaku-ji",
                    imagem = imagem1,
                    descricao = "O Kinkaku-ji, também chamado Pavilhão Dourado, é um dos templos mais famosos do Japão.",
                    localizacao = "Quioto, Japão"
                };

                monumentos[1] = new Monumento
                {
                    nome = "Monte Fuji",
                    imagem = imagem2,
                    descricao = "O Monte Fuji é a montanha mais alta do Japão e um dos símbolos mais importantes do país.",
                    localizacao = "Honshu, Japão"
                };

                monumentos[2] = new Monumento
                {
                    nome = "Castelo de Himeji",
                    imagem = imagem3,
                    descricao = "O Castelo de Himeji é um dos castelos mais bem preservados do Japão. É conhecido pela sua cor branca.",
                    localizacao = "Himeji, Japão"
                };
                break;

            case Pais.India:
                monumentos[0] = new Monumento
                {
                    nome = "Taj Mahal",
                    imagem = imagem1,
                    descricao = "O Taj Mahal é um dos monumentos mais famosos do mundo. Foi construído em mármore branco e é um símbolo do amor.",
                    localizacao = "Agra, Índia"
                };

                monumentos[1] = new Monumento
                {
                    nome = "Forte Vermelho",
                    imagem = imagem2,
                    descricao = "O Forte Vermelho é um importante exemplo da arquitetura mogol e um dos monumentos históricos mais conhecidos da Índia.",
                    localizacao = "Deli, Índia"
                };

                monumentos[2] = new Monumento
                {
                    nome = "Qutub Minar",
                    imagem = imagem3,
                    descricao = "O Qutub Minar é uma torre histórica muito conhecida pela sua altura e pelos detalhes decorativos em pedra.",
                    localizacao = "Deli, Índia"
                };
                break;

            case Pais.Portugal:
                monumentos[0] = new Monumento
                {
                    nome = "Castelo de Montemor-o-Velho",
                    imagem = imagem1,
                    descricao = "O Castelo de Montemor-o-Velho é uma fortificação medieval importante e teve grande valor defensivo durante a Reconquista.",
                    localizacao = "Montemor-o-Velho, Portugal"
                };

                monumentos[1] = new Monumento
                {
                    nome = "Sé de Lisboa",
                    imagem = imagem2,
                    descricao = "A Sé de Lisboa é a igreja mais antiga da cidade e um dos monumentos religiosos mais importantes de Portugal.",
                    localizacao = "Lisboa, Portugal"
                };

                monumentos[2] = new Monumento
                {
                    nome = "Monumento dos Descobrimentos",
                    imagem = imagem3,
                    descricao = "O Monumento dos Descobrimentos homenageia os navegadores portugueses e simboliza a expansão marítima portuguesa.",
                    localizacao = "Belém, Lisboa, Portugal"
                };
                break;
        }
    }

    public void MostrarMonumento(int indice)
    {
        if (monumentos == null || indice < 0 || indice >= monumentos.Length)
            return;

        if (imageGrande != null)
            imageGrande.sprite = monumentos[indice].imagem;

        if (descricaoTexto != null)
            descricaoTexto.text = monumentos[indice].descricao;

        if (localizacaoTexto != null)
            localizacaoTexto.text = monumentos[indice].localizacao;
    }
}