using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
    public class ModelProduto
    {
        public void SetProduto(DtoProduto pro)
        {
            Context db = new Context();

            db.produto.Add(pro);
            db.SaveChanges();
        }
        public void EditProduto(DtoProduto pro)
        {
            Context db = new Context();
            DtoProduto e = db.produto.FirstOrDefault(p => p.id_produto == pro.id_produto);
            e.nome_produto = pro.nome_produto;
            e.descricao = pro.descricao;
            e.marca = pro.marca;

            db.SaveChanges();
        }
        public List<DtoProduto2> ListProdutos()
        {
            Context db = new Context();
            List<DtoProduto2> result = (from a in db.produto
                                        select new DtoProduto2
                                        {
                                            id_produto = a.id_produto,
                                            nome_produto = a.nome_produto
                                        }).ToList();

            return new List<DtoProduto2>(result);
        }

        public DtoProduto2 GetProdutoId(int id_produto)
        {
            Context db = new Context();
            var result = (from a in db.produto
                          where a.id_produto == id_produto
                          select new DtoProduto2
                          {
                              id_produto = a.id_produto,
                              nome_produto = a.nome_produto
                          }).FirstOrDefault();

            var result1 = db.produto.Where(p => p.id_produto == id_produto).FirstOrDefault();

            return result;
        }

        public void DeletarProduto(int id_produto)
        {
            Context db = new Context();
            DtoProduto pro = db.produto.FirstOrDefault(p => p.id_produto == id_produto);
            db.produto.Remove(pro);
            db.SaveChanges();
        }
    }
}
