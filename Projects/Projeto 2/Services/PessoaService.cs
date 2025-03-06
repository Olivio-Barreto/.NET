namespace projeto_2.Services;

public class PessoaService
{
    private IPessoa _pessoa;

    public PessoaService(IPessoa pessoa)
    {
        _pessoa = pessoa;
    }

    public dynamic Apresentacao()
    {
        return _pessoa.ShowDetails();
    }
    
    
}