using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class _CarregaImagemPlano : MonoBehaviour
{

    [SerializeField]
    private string _arquivoImagem;
    [SerializeField]
    public Renderer _imagem;

    // Start is called before the first frame update
    void Start()
    {
        _arquivoImagem = PlayerPrefs.GetString("imagem");
        Debug.Log(_arquivoImagem);

        //   Debug.Log(StaticClass.CrossSceneInformation);
        //Sprite _img = GameObject.Find("imagem_a_editar").GetComponent<Image>();
        _imagem = GameObject.FindGameObjectWithTag("VP").GetComponent<Renderer>();
        if (_imagem != null)
        {
            _imagem.material.SetTexture("_MainTex", new CarregaTextura().getTextura (_arquivoImagem));
        }
        else
        {
            Debug.Log("erro 2" + _imagem.ToString());
        }
        //.image = new CarregaTextura().getTextura(_arquivoImagem);
    }



}
