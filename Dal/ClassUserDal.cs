using DEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
   public class ClassUserDal
    {
        Database_Connection SqlCon = new Database_Connection();
        SqlTransaction SqlTrans = null;
        public DataSet AuthenticateUser(ClassUser ObjUserEntities)
        {
            DataSet dsResult = null;
            try
            {

                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@UserName", ObjUserEntities.UserName);
                Param[1] = new SqlParameter("@Password", ObjUserEntities.Password);
                dsResult = MySqlHelper.ExecuteDataset(SqlTrans, CommandType.StoredProcedure, "usp_AuthenticateUser1", Param);

                SqlTrans.Commit();

            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                throw ex;
            }
            finally
            {
                SqlCon.CloseConnection();
            }
            return dsResult;
        }

        public DataSet FetchData(ClassUser ObjUser)
        {
            DataSet dsResult = null;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[1];
                //Param[0] = new SqlParameter("@UserId", ObjUser.UserID);
                dsResult = MySqlHelper.ExecuteDataset(SqlTrans, CommandType.StoredProcedure, "FetchUser", Param);
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
            }
            finally
            {
                SqlCon.CloseConnection();
            }

            return dsResult;
        }
        public DataSet FetchDataId(ClassUser ObjUser)
        {
            DataSet dsResult = null;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[2];
                Param[0] = new SqlParameter("@Id", ObjUser.UserId);
                Param[1] = new SqlParameter("@TaskId", ObjUser.TaskId);
                dsResult = MySqlHelper.ExecuteDataset(SqlTrans, CommandType.StoredProcedure, "FetchUserId", Param);
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
            }
            finally
            {
                SqlCon.CloseConnection();
            }

            return dsResult;
        }

        public DataSet FetchMoniter(ClassUser ObjUser)
        {
            DataSet dsResult = null;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[3];
                Param[0] = new SqlParameter("@Id", ObjUser.UserId);
                Param[1] = new SqlParameter("@TaskId", ObjUser.TaskId);
                Param[2] = new SqlParameter("@StatusId", ObjUser.StatusId);
                dsResult = MySqlHelper.ExecuteDataset(SqlTrans, CommandType.StoredProcedure, "FetchMoniter", Param);
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
            }
            finally
            {
                SqlCon.CloseConnection();
            }

            return dsResult;
        }


        public int UpdateUser(ClassUser ObjUser)
        {
            int pkID = 0;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[9];
                Param[0] = new SqlParameter("@Id", ObjUser.UserId);
                Param[1] = new SqlParameter("@StatusId", ObjUser.StatusId);
              
                Param[2] = new SqlParameter("@PkId", SqlDbType.Int);
                Param[2].Direction = ParameterDirection.Output;
                int result = MySqlHelper.ExecuteNonQuery(SqlTrans, CommandType.StoredProcedure, "Usp_UpdateStatus", Param);

                if (Convert.ToInt32(Param[2].Value) > 0)
                {
                    pkID = Convert.ToInt32(Param[2].Value);
                }
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                throw ex;
            }
            finally
            {
                SqlCon.CloseConnection();
            }
            return pkID;
        }

        public int UpdateProject(ClassUser ObjUser)
        {
            int pkID = 0;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[9];
                Param[0] = new SqlParameter("@Id", ObjUser.UserId);
                Param[1] = new SqlParameter("@Projectname", ObjUser.ProjectName);
                Param[2] = new SqlParameter("@DateTime", ObjUser.Date);
                Param[3] = new SqlParameter("@PkId", SqlDbType.Int);
                Param[3].Direction = ParameterDirection.Output;
                int result = MySqlHelper.ExecuteNonQuery(SqlTrans, CommandType.StoredProcedure, "Usp_UpdateProject", Param);

                if (Convert.ToInt32(Param[3].Value) > 0)
                {
                    pkID = Convert.ToInt32(Param[3].Value);
                }
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                throw ex;
            }
            finally
            {
                SqlCon.CloseConnection();
            }
            return pkID;
        }

        public int UpdateTaskMaster1(ClassUser ObjUser)
        {
            int pkID = 0;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[9];
                Param[0] = new SqlParameter("@Id", ObjUser.UserId);
                Param[1] = new SqlParameter("@Projectname", ObjUser.ProjectName);
               // Param[2] = new SqlParameter("@DateTime", ObjUser.Date);
                Param[2] = new SqlParameter("@PkId", SqlDbType.Int);
                Param[2].Direction = ParameterDirection.Output;
                int result = MySqlHelper.ExecuteNonQuery(SqlTrans, CommandType.StoredProcedure, "Usp_InsertTaskMaster", Param);

                if (Convert.ToInt32(Param[2].Value) > 0)
                {
                    pkID = Convert.ToInt32(Param[2].Value);
                }
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                throw ex;
            }
            finally
            {
                SqlCon.CloseConnection();
            }
            return pkID;
        }

        public int UpdateTaskMaster(ClassUser ObjUser)
        {
            int pkID = 0;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[9];
                Param[0] = new SqlParameter("@Id", ObjUser.UserId);
                Param[1] = new SqlParameter("@Projectname", ObjUser.ProjectName);
                Param[2] = new SqlParameter("@DateTime", ObjUser.Date);
                Param[3] = new SqlParameter("@PkId", SqlDbType.Int);
                Param[3].Direction = ParameterDirection.Output;
                int result = MySqlHelper.ExecuteNonQuery(SqlTrans, CommandType.StoredProcedure, "Usp_UpdateProject", Param);

                if (Convert.ToInt32(Param[3].Value) > 0)
                {
                    pkID = Convert.ToInt32(Param[3].Value);
                }
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                throw ex;
            }
            finally
            {
                SqlCon.CloseConnection();
            }
            return pkID;
        }


        public int InsertUser(ClassUser ObjUser)
        {
            int pkID = 0;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[9];
                Param[0] = new SqlParameter("@UserId", ObjUser.UserId);
                Param[1] = new SqlParameter("@UserName", ObjUser.ProjectName);
                Param[2] = new SqlParameter("@ExpiryDate", ObjUser.Date);
                Param[3] = new SqlParameter("@UserGroupID", ObjUser.UserGroupId);
                Param[4] = new SqlParameter("@Password", ObjUser.Password);

                Param[5] = new SqlParameter("@pkID", SqlDbType.Int);
                Param[5].Direction = ParameterDirection.Output;
                int result = MySqlHelper.ExecuteNonQuery(SqlTrans, CommandType.StoredProcedure, "usp_InsertUser", Param);

                if (Convert.ToInt32(Param[5].Value) > 0)
                {
                    pkID = Convert.ToInt32(Param[5].Value);
                }
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                throw ex;
            }
            finally
            {
                SqlCon.CloseConnection();
            }
            return pkID;
        }




        public int UpdateProjectExcuton(ClassUser ObjUser)
        {
            int pkID = 0;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[9];
                Param[0] = new SqlParameter("@ProjectId", ObjUser.ProjectId);
                Param[1] = new SqlParameter("@WorkId", ObjUser.WorkId);
                Param[2] = new SqlParameter("@StatusId", ObjUser.StatusId);
                Param[3] = new SqlParameter("@GroupId", ObjUser.UserGroupId);
                Param[4] = new SqlParameter("@description", ObjUser.Description);
                Param[5] = new SqlParameter("@Date", ObjUser.Date);
                Param[6] = new SqlParameter("@TaskId", ObjUser.TaskId);
                Param[7] = new SqlParameter("@RoleId", ObjUser.UserGroupId);
                Param[8] = new SqlParameter("@PkId", SqlDbType.Int);
                Param[8].Direction = ParameterDirection.Output;
                int result = MySqlHelper.ExecuteNonQuery(SqlTrans, CommandType.StoredProcedure, "Usp_InsertExcution", Param);

                if (Convert.ToInt32(Param[8].Value) > 0)
                {
                    pkID = Convert.ToInt32(Param[8].Value);
                }
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                throw ex;
            }
            finally
            {
                SqlCon.CloseConnection();
            }
            return pkID;
        }

        public int DeleteProject(ClassUser ObjUser)
        {
            int pkID = 0;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[9];
                Param[0] = new SqlParameter("@Id", ObjUser.UserId);
                Param[2] = new SqlParameter("@PkId", SqlDbType.Int);
                Param[2].Direction = ParameterDirection.Output;
                int result = MySqlHelper.ExecuteNonQuery(SqlTrans, CommandType.StoredProcedure, "Usp_DeleteProject", Param);

                if (Convert.ToInt32(Param[2].Value) > 0)
                {
                    pkID = Convert.ToInt32(Param[2].Value);
                }
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                throw ex;
            }
            finally
            {
                SqlCon.CloseConnection();
            }
            return pkID;
        }


        public int DeleteTaskDetails1(ClassUser ObjUser)
        {
            int pkID = 0;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[9];
                Param[0] = new SqlParameter("@Id", ObjUser.UserId);
                Param[2] = new SqlParameter("@PkId", SqlDbType.Int);
                Param[2].Direction = ParameterDirection.Output;
                int result = MySqlHelper.ExecuteNonQuery(SqlTrans, CommandType.StoredProcedure, "Usp_DeleteTask", Param);

                if (Convert.ToInt32(Param[2].Value) > 0)
                {
                    pkID = Convert.ToInt32(Param[2].Value);
                }
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                throw ex;
            }
            finally
            {
                SqlCon.CloseConnection();
            }
            return pkID;
        }

        public int DeleteTaskDetails(ClassUser ObjUser)
        {
            int pkID = 0;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[9];
                Param[0] = new SqlParameter("@Id", ObjUser.UserId);
                Param[2] = new SqlParameter("@PkId", SqlDbType.Int);
                Param[2].Direction = ParameterDirection.Output;
                int result = MySqlHelper.ExecuteNonQuery(SqlTrans, CommandType.StoredProcedure, "Usp_DeleteProject", Param);

                if (Convert.ToInt32(Param[2].Value) > 0)
                {
                    pkID = Convert.ToInt32(Param[2].Value);
                }
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                throw ex;
            }
            finally
            {
                SqlCon.CloseConnection();
            }
            return pkID;
        }

        public int PreAdminProject(ClassUser ObjUser)
        {
            int pkID = 0;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[9];
                Param[0] = new SqlParameter("@Id", ObjUser.UserId);
                Param[2] = new SqlParameter("@PkId", SqlDbType.Int);
                Param[2].Direction = ParameterDirection.Output;
                int result = MySqlHelper.ExecuteNonQuery(SqlTrans, CommandType.StoredProcedure, "Usp_PreAdminProject", Param);

                if (Convert.ToInt32(Param[2].Value) > 0)
                {
                    pkID = Convert.ToInt32(Param[2].Value);
                }
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                throw ex;
            }
            finally
            {
                SqlCon.CloseConnection();
            }
            return pkID;
        }
        public int PostAdminProject(ClassUser ObjUser)
        {
            int pkID = 0;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[9];
                Param[0] = new SqlParameter("@Id", ObjUser.UserId);
                Param[2] = new SqlParameter("@PkId", SqlDbType.Int);
                Param[2].Direction = ParameterDirection.Output;
                int result = MySqlHelper.ExecuteNonQuery(SqlTrans, CommandType.StoredProcedure, "Usp_PostAdminProject", Param);

                if (Convert.ToInt32(Param[2].Value) > 0)
                {
                    pkID = Convert.ToInt32(Param[2].Value);
                }
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                throw ex;
            }
            finally
            {
                SqlCon.CloseConnection();
            }
            return pkID;
        }
        public int ExcAdminProject(ClassUser ObjUser)
        {
            int pkID = 0;
            try
            {
                SqlCon.OpenConnection();
                SqlTrans = SqlCon.con.BeginTransaction();
                SqlParameter[] Param = new SqlParameter[9];
                Param[0] = new SqlParameter("@Id", ObjUser.UserId);
                Param[2] = new SqlParameter("@PkId", SqlDbType.Int);
                Param[2].Direction = ParameterDirection.Output;
                int result = MySqlHelper.ExecuteNonQuery(SqlTrans, CommandType.StoredProcedure, "Usp_ExceAdminProject", Param);

                if (Convert.ToInt32(Param[2].Value) > 0)
                {
                    pkID = Convert.ToInt32(Param[2].Value);
                }
                SqlTrans.Commit();
            }
            catch (Exception ex)
            {
                SqlTrans.Rollback();
                throw ex;
            }
            finally
            {
                SqlCon.CloseConnection();
            }
            return pkID;
        }
    }
}
