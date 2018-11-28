export class Produto {
    public id: number
    public nome: string

    constructor(private sigla: string, private preco: number)
    {

    }

    public exibirSigla()
    {
        alert(this.sigla);
    }

    public obterNome():string
    {
        return this.nome;
    }

    public obterId(): number
    {
        return this.id;
    }

    set setNome(nome)
    {
        this.nome = nome;
    }

    get getNome()
    {
        return this.nome;
    }
}
