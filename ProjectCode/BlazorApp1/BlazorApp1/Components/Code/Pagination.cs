public class Pagination{
    private int currentPage;
    private int totalPages;
    private int totalItems;  
    private int itemsPerPage = 15;

    public Pagination(){
        this.currentPage = 1;
        this.totalPages = 1;
        this.totalItems = 0;
    }

    public Pagination(int totalItems){
        this.totalItems = totalItems;
        this.totalPages = (int)Math.Ceiling(this.totalItems / (double)this.itemsPerPage);
    }

    public int GetTotalPages(){
        return this.totalPages;
    }

    public int GetCurrentPage(){
        return this.currentPage;
    }

    public int GetItemsForPage(){
        if (this.currentPage == this.totalPages)
        {
            return this.totalItems - ((this.currentPage - 1) * this.itemsPerPage);
        }
        else
        {
            return this.itemsPerPage;
        }
    }

    public int GetStartIndex(){
        return (this.currentPage - 1) * this.itemsPerPage;
    }

    public int GetEndIndex(){
        return (this.currentPage * this.itemsPerPage) - 1;
    }


    public void SetCurrentPage(int page){
        if(page > 0 && page <= this.totalPages){
            this.currentPage = page;
        }
    }

}