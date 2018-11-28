"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Produto = /** @class */ (function () {
    function Produto(sigla, preco) {
        this.sigla = sigla;
        this.preco = preco;
    }
    Produto.prototype.exibirSigla = function () {
        alert(this.sigla);
    };
    Produto.prototype.obterNome = function () {
        return this.nome;
    };
    Produto.prototype.obterId = function () {
        return this.id;
    };
    Object.defineProperty(Produto.prototype, "setNome", {
        set: function (nome) {
            this.nome = nome;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Produto.prototype, "getNome", {
        get: function () {
            return this.nome;
        },
        enumerable: true,
        configurable: true
    });
    return Produto;
}());
exports.Produto = Produto;
//# sourceMappingURL=Produto.js.map