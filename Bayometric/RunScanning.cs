using Neurotec.Biometrics;
using System;
using System.ComponentModel;
using Neurotec.Gui;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Bayometric
{
    public class RunScanning
    {
        readonly Nffv _engine;
        readonly string _userDatabaseFile;
        readonly UserDatabase _userDB;
        public RunScanning(Nffv engine, string userDatabaseFile)
        {
            _engine = engine;

            _userDatabaseFile = userDatabaseFile;
            try
            {
                _userDB = UserDatabase.ReadFromFile(userDatabaseFile);
            }
            catch
            {
                _userDB = new UserDatabase();
            }
        }

        internal class EnrollmentResult
        {
            public NffvStatus engineStatus;
            public NffvUser engineUser;
        };

        private void Enroll(string userName, ref Guna2CirclePictureBox pictureBox)
        {
            if (_engine.Users.Count >= Nffv.MaxUserCount)
            {
                MessageBox.Show("Maximum number of users is reached.");
            }
            try
            {
                RunWorkerCompletedEventArgs taskResult = BusyForm.RunLongTask("Waiting for fingerprint ...", new DoWorkEventHandler(DoEnroll),
                    false, null, new EventHandler(CancelScanningHandler));
                EnrollmentResult enrollmentResult = (EnrollmentResult)taskResult.Result;
                if (enrollmentResult.engineStatus == NffvStatus.TemplateCreated)
                {
                    NffvUser engineUser = enrollmentResult.engineUser;
                    if (userName.Length <= 0)
                    {
                        userName = engineUser.Id.ToString();
                    }

                    _userDB.Add(new UserRecord(engineUser.Id, userName));
                    try
                    {
                        _userDB.WriteToFile(_userDatabaseFile);
                    }
                    catch { }

                    pictureBox.Image = engineUser.GetBitmap();
                }
                else
                {
                    NffvStatus engineStatus = enrollmentResult.engineStatus;
                    MessageBox.Show(string.Format("Enrollment was not finished. Reason: {0}", engineStatus));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoEnroll(object sender, DoWorkEventArgs args)
        {
            EnrollmentResult enrollmentResults = new EnrollmentResult();
            enrollmentResults.engineUser = _engine.Enroll(20000, out enrollmentResults.engineStatus);
            args.Result = enrollmentResults;
        }

        internal class VerificationResult
        {
            public NffvStatus engineStatus;
            public int score;
        };

        private void Verify(CData User)
        {
            try
            {
                RunWorkerCompletedEventArgs taskResult = BusyForm.RunLongTask("Waiting for fingerprint ...", new DoWorkEventHandler(DoVerify),
                    false, ((CData)User).EngineUser, new EventHandler(CancelScanningHandler));
                VerificationResult verificationResult = (VerificationResult)taskResult.Result;
                if (verificationResult.engineStatus == NffvStatus.TemplateCreated)
                {
                    if (verificationResult.score > 0)
                    {
                        MessageBox.Show(string.Format("{0} verified.\r\nFingerprints match. Score: {1}", ((CData)User).Name, verificationResult.score));
                    }
                    else
                    {
                        MessageBox.Show(string.Format("{0} not verified.\r\nFingerprints do not match. Score: {1}", ((CData)User).Name, verificationResult.score));
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("Verification was not finished. Reason: {0}", verificationResult.engineStatus));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DoVerify(object sender, DoWorkEventArgs args)
        {
            VerificationResult verificationResult = new VerificationResult();
            verificationResult.score = _engine.Verify((NffvUser)args.Argument, 20000, out verificationResult.engineStatus);
            args.Result = verificationResult;
        }

        private void CancelScanningHandler(object sender, EventArgs e)
        {
            _engine.Cancel();
        }
    }

    public class CData : IDisposable
    {
        private readonly NffvUser _engineUser;
        private Bitmap _image;
        private string _name;

        public CData(NffvUser engineUser, string name)
        {
            _engineUser = engineUser;
            _image = engineUser.GetBitmap();
            _name = name;
        }

        public NffvUser EngineUser
        {
            get
            {
                return _engineUser;
            }
        }

        public Bitmap Image
        {
            get
            {
                return _image;
            }
        }

        public int ID
        {
            get
            {
                return _engineUser.Id;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public override string ToString()
        {
            return Name;
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_image != null)
            {
                _image.Dispose();
                _image = null;
            }
        }

        #endregion
    }
}

