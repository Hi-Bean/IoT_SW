
// MiniProject1_MFCDlg.cpp: 구현 파일
//

#include "pch.h"
#include "framework.h"
#include "MiniProject1_MFC.h"
#include "MiniProject1_MFCDlg.h"
#include "afxdialogex.h"
#include "CDlgSave.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

const int WM_FINDREPLACE = ::RegisterWindowMessage(FINDMSGSTRING);
int findPos;
// 응용 프로그램 정보에 사용되는 CAboutDlg 대화 상자입니다.

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// 대화 상자 데이터입니다.
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_ABOUTBOX };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 지원입니다.

// 구현입니다.
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(IDD_ABOUTBOX)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// CMiniProject1MFCDlg 대화 상자



CMiniProject1MFCDlg::CMiniProject1MFCDlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_MINIPROJECT1_MFC_DIALOG, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CMiniProject1MFCDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_EDIT_MEMO1, CMemo1);
}

BEGIN_MESSAGE_MAP(CMiniProject1MFCDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_SIZE()
	ON_WM_ACTIVATE()
	ON_COMMAND(ID_MNU_OPEN, &CMiniProject1MFCDlg::OnMnuOpen)
	ON_COMMAND(ID_MNU_SAVE, &CMiniProject1MFCDlg::OnMnuSave)
	ON_COMMAND(ID_MNU_EXIT, &CMiniProject1MFCDlg::OnMnuExit)
	ON_COMMAND(ID_MNU_NEW, &CMiniProject1MFCDlg::OnMnuNew)
	ON_WM_CLOSE()
	ON_WM_MBUTTONDOWN()
	ON_COMMAND(ID_MNU_FONT, &CMiniProject1MFCDlg::OnMnuFont)
	ON_COMMAND(ID_MNU_PAGE, &CMiniProject1MFCDlg::OnMnuPage)
	ON_COMMAND(ID_MNU_PRINT, &CMiniProject1MFCDlg::OnMnuPrint)
	ON_COMMAND(ID_MNU_FIND, &CMiniProject1MFCDlg::OnMnuFind)
	ON_COMMAND(ID_MNU_REPLACE, &CMiniProject1MFCDlg::OnMnuReplace)
	ON_REGISTERED_MESSAGE(WM_FINDREPLACE, OnFindReplace)
	ON_COMMAND(ID_MNU_DATE, &CMiniProject1MFCDlg::OnMnuDate)
	ON_COMMAND(ID_MNU_LOWER, &CMiniProject1MFCDlg::OnMnuLower)
	ON_COMMAND(ID_MNU_UPPER, &CMiniProject1MFCDlg::OnMnuUpper)
	ON_COMMAND(ID_MNU_TOT, &CMiniProject1MFCDlg::OnMnuTot)
END_MESSAGE_MAP()


// CMiniProject1MFCDlg 메시지 처리기

BOOL CMiniProject1MFCDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// 시스템 메뉴에 "정보..." 메뉴 항목을 추가합니다.

	// IDM_ABOUTBOX는 시스템 명령 범위에 있어야 합니다.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != nullptr)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// 이 대화 상자의 아이콘을 설정합니다.  응용 프로그램의 주 창이 대화 상자가 아닐 경우에는
	//  프레임워크가 이 작업을 자동으로 수행합니다.
	SetIcon(m_hIcon, TRUE);			// 큰 아이콘을 설정합니다.
	SetIcon(m_hIcon, FALSE);		// 작은 아이콘을 설정합니다.
	
	ShowWindow(SW_SHOW);

	// TODO: 여기에 추가 초기화 작업을 추가합니다.

	m_Font.CreatePointFont(100, _T("Time New Romans"));
	
	return TRUE;  // 포커스를 컨트롤에 설정하지 않으면 TRUE를 반환합니다.
}

void CMiniProject1MFCDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// 대화 상자에 최소화 단추를 추가할 경우 아이콘을 그리려면
//  아래 코드가 필요합니다.  문서/뷰 모델을 사용하는 MFC 애플리케이션의 경우에는
//  프레임워크에서 이 작업을 자동으로 수행합니다.

void CMiniProject1MFCDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // 그리기를 위한 디바이스 컨텍스트입니다.

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// 클라이언트 사각형에서 아이콘을 가운데에 맞춥니다.
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// 아이콘을 그립니다.
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// 사용자가 최소화된 창을 끄는 동안에 커서가 표시되도록 시스템에서
//  이 함수를 호출합니다.
HCURSOR CMiniProject1MFCDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}



void CMiniProject1MFCDlg::OnSize(UINT nType, int cx, int cy)
{
	CDialogEx::OnSize(nType, cx, cy);

	// TODO: 여기에 메시지 처리기 코드를 추가합니다.
	if (GetDlgItem(IDC_EDIT_MEMO1) != NULL)
	{
		CMemo1.SetWindowPos(NULL, 0, 0, cx, cy, 0);
	}
}

//
void CMiniProject1MFCDlg::OnActivate(UINT nState, CWnd* pWndOther, BOOL bMinimized)
{
	CDialogEx::OnActivate(nState, pWndOther, bMinimized);
	CRect r;
	GetClientRect(&r);

	OnSize(0, r.Width(), r.Height());
}


// MENU - 파일(F) - 열기(O)
void CMiniProject1MFCDlg::OnMnuOpen()
{
	// TODO: 여기에 명령 처리기 코드를 추가합니다.
	OPENFILENAME ofn;
	char fname[512];
	HWND hwnd = m_hWnd;
	HANDLE hd;
	FILE* fp;

	// open a file name
	ZeroMemory(&ofn, sizeof(ofn));		// 메모리 clear  ===> 0
	ofn.lStructSize = sizeof(ofn);
	ofn.hwndOwner = hwnd;
	ofn.lpstrFile = fname;				// 선택한 file명

	ofn.lpstrFile[0] = '\0';
	ofn.nMaxFile = sizeof(fname);
	ofn.lpstrFilter = "All\0*.*\0Text\0*.TXT\0";
	ofn.nFilterIndex = 1;
	ofn.lpstrFileTitle = NULL;
	ofn.nMaxFileTitle = 0;
	ofn.lpstrInitialDir = NULL;
	ofn.Flags = OFN_PATHMUSTEXIST | OFN_FILEMUSTEXIST;

	// Display the Open dialog box

	if (GetOpenFileName(&ofn) == TRUE)
	{

		CString cstr;
		fp = fopen(fname, "r+b");
		char* buf = fname;
		while (fgets(buf, 512, fp) != NULL)
		{
			cstr += buf;
		}
		CMemo1.SetWindowTextA(cstr);
		fclose(fp);
	}
}

// MENU - 파일(F) - 저장(S)
void CMiniProject1MFCDlg::OnMnuSave()
{
	CString m_strPath;
	CString cstr;
	CStdioFile file;

	// CFile file;
	CFileException ex;
	CFileDialog dlg(FALSE, _T("*.txt"), NULL, OFN_FILEMUSTEXIST | OFN_OVERWRITEPROMPT, _T("TXT Files(*.txt)|*.txt|"), NULL);

	if (dlg.DoModal() == IDOK)
	{
		m_strPath = dlg.GetPathName();
		if (m_strPath.Right(4) != ".txt")
		{
			m_strPath += ".txt";
		}

		file.Open(m_strPath, CFile::modeCreate | CFile::modeReadWrite, &ex);

		// edit box 내용 저장
		UpdateData(TRUE);
		CMemo1.GetWindowTextA(cstr);
		file.WriteString(cstr);

		// 파일 종료
		file.Close();
	}

}

// MENU - 파일(F) - 종료(E)
void CMiniProject1MFCDlg::OnMnuExit()
{
	EndDialog(0);
}

// MENU - 파일(F) - 새로 만들기(N)
void CMiniProject1MFCDlg::OnMnuNew()
{
	//// modal dilalog	: 모달 대화상자 실행 중 메인화면 제어 불가능
	//CMiniProject1MFCDlg dialog_test;
	//dialog_test.DoModal();

	// modaless dilalog	: 모달리스 대화상자 실행 중 메인화면 제어 가능
	/*CMiniProject1MFCDlg* m_pDlgTest;
	m_pDlgTest = new CMiniProject1MFCDlg;
	m_pDlgTest->Create(IDD_MINIPROJECT1_MFC_DIALOG, GetDesktopWindow());
	m_pDlgTest->ShowWindow(SW_SHOWNORMAL);*/

	// 저장 여부 메세지 박스
	CDlgSave Csave;
	Csave.DoModal();

	// 저장 (OK)
	if(Csave.state == 1)
	{
		OnMnuSave();
		ShellExecute(NULL, "open", "C:\\Users\\hallo\\source\\repos\\IoT_SW\\ServerProgramming\\MiniProject1_MFC\\Debug\\MiniProject1_MFC", NULL, NULL, SW_SHOW);
		EndDialog(0);
	}
	else if (Csave.state == 2)		// 저장 안함
	{
		ShellExecute(NULL, "open", "C:\\Users\\hallo\\source\\repos\\IoT_SW\\ServerProgramming\\MiniProject1_MFC\\Debug\\MiniProject1_MFC", NULL, NULL, SW_SHOW);
		EndDialog(0);
	}

	delete Csave;

	//system("C:\\Users\\hallo\\source\\repos\\IoT_SW\\ServerProgramming\\MiniProject1_MFC\\Debug\\MiniProject1_MFC");
	/*ShellExecute(NULL, "open", "C:\\Users\\hallo\\source\\repos\\IoT_SW\\ServerProgramming\\MiniProject1_MFC\\Debug\\MiniProject1_MFC", NULL, NULL, SW_SHOW);
	EndDialog(0);*/
}

void CMiniProject1MFCDlg::SaveFunction()
{
	CString m_strPath;
	CString cstr;
	CStdioFile file;

	// CFile file;
	CFileException ex;
	CFileDialog dlg(FALSE, _T("*.txt"), NULL, OFN_FILEMUSTEXIST | OFN_OVERWRITEPROMPT, _T("TXT Files(*.txt)|*.txt|"), NULL);

	if (dlg.DoModal() == IDOK)
	{
		m_strPath = dlg.GetPathName();
		if (m_strPath.Right(4) != ".txt")
		{
			m_strPath += ".txt";
		}

		file.Open(m_strPath, CFile::modeCreate | CFile::modeReadWrite, &ex);

		// edit box 내용 저장
		UpdateData(TRUE);
		CMemo1.GetWindowTextA(cstr);
		file.WriteString(cstr);

		// 파일 종료
		file.Close();
		EndDialog(0);
	}
}

void CMiniProject1MFCDlg::OnClose()
{
	// TODO: 여기에 메시지 처리기 코드를 추가 및/또는 기본값을 호출합니다.
	
	CString str;
	CMemo1.GetWindowTextA(str);
	// Edit창에 아무것도 없을 때 x 버튼 누르면 그냥 꺼짐
	if(str == "")
		CDialogEx::OnClose();
	else   // 작성된 경우에는 저장 여부 메세지 박스
	{
		CDlgSave Csave;
		Csave.DoModal();

		// 저장 (OK)
		if (Csave.state == 1)
		{
			OnMnuSave();
			EndDialog(0);
		}
		else if (Csave.state == 2)
		{
			EndDialog(0);
		}

		delete Csave;
	}
	
	//CDialogEx::OnClose();
}



void CMiniProject1MFCDlg::OnMnuFont()
{
	m_Font.GetLogFont(&m_LogFont);
	CFontDialog dlg(&m_LogFont);
	CString strText;
	CMemo1.GetWindowTextA(strText);

	if (dlg.DoModal() == IDOK)
	{
		dlg.m_cf.Flags = dlg.m_cf.Flags | CF_INITTOLOGFONTSTRUCT | CF_EFFECTS;
		dlg.GetCurrentFont(&m_LogFont);
		m_Font.DeleteObject();
		m_Font.CreateFontIndirectA(&m_LogFont);
		CMemo1.SetFont(&m_Font);
	}

}


void CMiniProject1MFCDlg::OnMnuPage()
{
	CPageSetupDialog dlg;
	dlg.DoModal();
}


void CMiniProject1MFCDlg::OnMnuPrint()
{
	CPrintDialogEx dlg; // 인쇄설정 
	dlg.DoModal();
}

void CMiniProject1MFCDlg::OnMnuFind()
{
	// dlg is a pointer to a class derived from CFindReplaceDialog
	// which defines variables used by the FINDREPLACE structure.
	// InitFindReplaceDlg creates a CFindReplaceDialog and initializes
	// the m_fr with the data members from the derived class
	CFindReplaceDialog* pFindDlg = new CFindReplaceDialog; // Must be created on the heap
	if (!pFindDlg->Create(TRUE, _T(""), NULL, FR_DOWN | FR_MATCHDIAC, this)) //The above describes
	{
		return;
	}
	pFindDlg->ShowWindow(SW_SHOW);   //The window must be displayed after it is created
	pFindDlg->SetActiveWindow();    //Set as the active window
	
}


void CMiniProject1MFCDlg::OnMnuReplace()
{
	CFindReplaceDialog* pReplaceDlg = new CFindReplaceDialog;
	findPos = -1;
	if (!pReplaceDlg->Create(FALSE, _T(""), _T(""), FR_DOWN, this))
	{
		return;
	}
	pReplaceDlg->ShowWindow(SW_SHOW);
	pReplaceDlg->SetActiveWindow();
}


LRESULT CMiniProject1MFCDlg::OnFindReplace(WPARAM wParam, LPARAM lParam)
{
	int startSel = 0, endSel = 0;
	CFindReplaceDialog* pDlg = CFindReplaceDialog::GetNotifier(lParam);
	CString buffer, findString, tBuf, rp;
	CMemo1.GetWindowTextA(buffer);
	tBuf = buffer;
		
	if (pDlg != NULL)
	{
			if (pDlg->FindNext())
			{
				MessageBox("Find!", "notice", MB_OK);
				findString = pDlg->GetFindString();
				
				findPos = 0;
				char* str = tBuf.GetBuffer() + findPos;
				CString b1 = (CString)str;
				int count = 0;

				while (b1.Find(findString) >= 0)
				{
					findPos = b1.Find(findString);

					if (count < 1)
					{
						startSel += findPos;
					}
					else
						startSel += findPos + findString.GetLength();

					endSel = startSel + findString.GetLength();
					CMemo1.SetSel(startSel, endSel); //system("PAUSE");
					str = b1.GetBuffer() + findPos + findString.GetLength();

					count++;
					b1 = (CString)str;
					CString n; n.Format("%d번 찾았습니다", count);
					MessageBoxA(n, "찾기 진행 중", MB_OKCANCEL);
					
				}
				CString m; m.Format("%s를 총 %d번 찾았습니다", findString, count);
				MessageBoxA(m, "찾기 완료", MB_OKCANCEL);
			}
			else if (pDlg->ReplaceAll())		// findString과 rp의 길이가 같아야만 정상작동 (추후 업데이트예정)
			{
				MessageBox("ReplaceAll!", "notice", MB_OK);
				findString = pDlg->GetFindString();
				rp = pDlg->GetReplaceString();
				findPos = 0;
				char* str = tBuf.GetBuffer() + findPos;
				CString b2 = (CString)str;
				int count = 0;

				while (b2.Find(findString) >= 0)
				{
					findPos = b2.Find(findString);

					if (count < 1)
					{
						startSel += findPos;
					}
					else
						startSel += findPos + findString.GetLength();

					endSel = startSel + findString.GetLength();
					CMemo1.SetSel(startSel, endSel);
					//system("PAUSE");
					CMemo1.ReplaceSel(rp);
					//system("PAUSE");
				
					str = b2.GetBuffer() + findPos + findString.GetLength();

					count++;
					b2 = (CString)str;
				}
				CString m; m.Format("%s를 %d번 바꿨습니다", findString, count);
				MessageBoxA(m, "바꾸기", MB_OKCANCEL);
			}
			else if (pDlg->ReplaceCurrent())
			{
				MessageBox("ReplaceCurrent!", "notice", MB_OK);
				rp = pDlg->GetReplaceString();
				CMemo1.ReplaceSel(rp);
			}
	}
	//if (pDlg->IsTerminating())
 //     {
 //        CString csFindString;
 //        CString csReplaceString;

 //        csFindString = pDlg->GetFindString();
 //        csReplaceString = pDlg->GetReplaceString();

	//	 int src_str_len = GetDlgItemText(IDC_EDIT_MEMO1, csFindString);

 //        VERIFY(pDlg->DestroyWindow());
 //     }
	//delete pDlg; //Add this will automatically destroy the dialog
	return 0;

}


void CMiniProject1MFCDlg::OnMnuDate()
{
	CTime cTime = CTime::GetCurrentTime();
	CString strDT;

	strDT.Format("%02d:%02d %04d-%02d-%02d", cTime.GetHour(), cTime.GetMinute(), cTime.GetYear(), cTime.GetMonth(), cTime.GetDay());
	int nLen = CMemo1.GetWindowTextLengthA();
	
	CMemo1.SetFocus();
	CMemo1.SetSel(nLen, nLen);
	CMemo1.ReplaceSel(strDT);
}



void CMiniProject1MFCDlg::OnMnuLower()
{
	CString str;
	CMemo1.GetWindowTextA(str);
	CMemo1.SetWindowTextA(str.MakeLower());
}


void CMiniProject1MFCDlg::OnMnuUpper()
{
	CString str;
	CMemo1.GetWindowTextA(str);
	CMemo1.SetWindowTextA(str.MakeLower());
}


void CMiniProject1MFCDlg::OnMnuTot()
{
	CString str;
	int len = CMemo1.GetWindowTextLengthA();
	str.Format("총 길이는 %d 입니다", len);
	AfxMessageBox(str);


}
