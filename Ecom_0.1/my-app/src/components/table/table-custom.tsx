import { Pagination, PaginationProps, Table } from "antd";
import { AnyObject } from "antd/es/_util/type";
import { ColumnsType } from "antd/es/table";
import "./table-custom.scss"

type TableCustomProps = {
    columns?: ColumnsType<AnyObject>;
    dataSource?:any[];
    curentPage?: number;
    totalPage?:number;
    setCurrent?:(val:any)=>void
}

const TableCustom:React.FC<TableCustomProps> = ({
    columns,
    dataSource,
    curentPage,
    totalPage,
    setCurrent
}) => {
    const onShowSizeChange: PaginationProps['onShowSizeChange'] = (current, pageSize) => {
        console.log(current, pageSize);
    };

    const onChange: PaginationProps['onChange'] = (page) => {
        setCurrent?.(page);
      };

    return (
        <div className="table-custom">
            <Table 
                className="table-custom-style"
                columns={columns}
                dataSource={dataSource}
                bordered
                pagination={false}
                
                footer={()=> (
                    <Pagination 
                        onShowSizeChange={onShowSizeChange}
                        onChange={onChange}
                        align="end"
                        current={curentPage}
                        total={totalPage}
                        showSizeChanger  
                    /> 
                )}
            />
        </div>
    );
}

export default TableCustom;