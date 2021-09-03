
// MFCMemo4Dlg.cpp: 구현 파일
//

#include "pch.h"
#include "framework.h"
#include "MFCMemo4.h"
#include "MFCMemo4Dlg.h"
#include "afxdialogex.h"
#include "CDlgTest.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


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


// CMFCMemo4Dlg 대화 상자



CMFCMemo4Dlg::CMFCMemo4Dlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_MFCMEMO4_DIALOG, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CMFCMemo4Dlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_TB_MEMO1, CMemo1);
	DDX_Control(pDX, IDC_TB_MEMO2, CMemo2);
	DDX_Control(pDX, IDC_RADIO1, CRadio1);
	DDX_Control(pDX, IDC_RADIO2, CRadio2);
}

BEGIN_MESSAGE_MAP(CMFCMemo4Dlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON1, &CMFCMemo4Dlg::OnClickedButton1)
	ON_COMMAND(ID_MNU_VIEW_LOWER, &CMFCMemo4Dlg::OnMnuViewLower)
	ON_COMMAND(ID_MNU_VIEW_UPPER, &CMFCMemo4Dlg::OnMnuViewUpper)
	ON_COMMAND(ID_MNU_FILE_EXIT, &CMFCMemo4Dlg::OnMnuFileExit)
	ON_COMMAND(ID_MNU_VIEW_HEX, &CMFCMemo4Dlg::OnMnuViewHex)
	ON_COMMAND(ID_MNU_FILE_OPEN, &CMFCMemo4Dlg::OnMnuFileOpen)
	ON_WM_SIZE()
	ON_WM_ACTIVATE()
	ON_BN_CLICKED(IDC_BUTTON2, &CMFCMemo4Dlg::OnClickedButton2)
END_MESSAGE_MAP()


// CMFCMemo4Dlg 메시지 처리기

BOOL CMFCMemo4Dlg::OnInitDialog()
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
	((CButton*)GetDlgItem(IDC_RADIO1))->SetState(true);

	return TRUE;  // 포커스를 컨트롤에 설정하지 않으면 TRUE를 반환합니다.
}

void CMFCMemo4Dlg::OnSysCommand(UINT nID, LPARAM lParam)
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

void CMFCMemo4Dlg::OnPaint()
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
HCURSOR CMFCMemo4Dlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CMFCMemo4Dlg::OnClickedButton1()
{
	//static bool changeAlphabet = true;	// 함수 내에서 선언 시에는 static 키워드 사용!
	static int Count = 0;
	CString cstr, s1, cs;
	char buf[1024];
	char* sp = buf;			// buf의 첫번째 위치를 가리키고 있음
	char* str = "abcdefghijklmnopqrstuvwxyz";
	////char* str = strMemo.GetBuffer();	// 속성-고급-문자집합-설정안함 => 아스키코드로 바꿈
	//									// 일반적인 경우, strMemo의 타입은 유니코드형식

	for (int i = 0; *(str + i); i++)	// i < strlen(str)
	{
		// char 배열 및 포인터를 이용한 경우
		sprintf(sp, "%02X ", *(str + i));
		while (*sp)	sp++;					// sp위치 증가 -> buf의 다음 공간을 가리킴
		
		// Cstring class를 이용한 경우
		s1.Format("%02X ", str[i]);
		cs += s1;
	}
	CMemo2.SetWindowTextA(buf);
	CMemo2.SetWindowTextA(cs);
	
	////int len = CMemo1.GetWindowTextA(buf, 1000);
	////if (changeAlphabet)		// 소문자 -> 대문자 : (a~z) ---> (a~z) - 0x20
	////{
	////	for (int i = 0; i < len; i++)
	////	{
	////		if (buf[i] >= 'a' && buf[i] <= 'z')
	////			buf[i] -= 0x20;
	////	}
	////	changeAlphabet = false;
	////}
	////else					// 대문자 -> 소문자 : (A~Z) ---> (A~Z) + 0x20
	////{
	////	for (int i = 0; i < len; i++)
	////	{
	////		if (buf[i] >= 'A' && buf[i] <= 'Z')
	////			buf[i] += 0x20;
	////	}
	////	changeAlphabet = true;
	////}
	////Memo2.SetWindowTextA(buf);

	
	//CMemo1.GetWindowTextA(cstr);
	//if (CRadio1.GetState())
	//	s1 = cstr.MakeLower();
	//else if (CRadio2.GetState())
	//	s1 = cstr.MakeUpper();

	//// check box를 이용한 변환
	///*if (((CButton*)GetDlgItem(IDC_CHECK1))->GetState() == true)
	//	s1 = cstr.MakeLower();
	//else
	//	s1 = cstr.MakeUpper();*/

	//	//if (Count % 2 == 1)
	//	//	s1 = cstr.MakeLower();		// 원본 불변의 법칙  => 원본이 바뀌는 것 X
	//	//else
	//	//	s1 = cstr.MakeUpper();
	//CMemo2.SetWindowTextA(s1);
	//Count++;
}


void CMFCMemo4Dlg::OnMnuViewLower()
{
	CString cstr;
	CMemo1.GetWindowTextA(cstr);
	CMemo2.SetWindowTextA(cstr.MakeLower());
}


void CMFCMemo4Dlg::OnMnuViewUpper()
{
	CString cstr;
	CMemo1.GetWindowTextA(cstr);
	CMemo2.SetWindowTextA(cstr.MakeUpper());
}


void CMFCMemo4Dlg::OnMnuFileExit()
{
	EndDialog(0);
}


void CMFCMemo4Dlg::OnMnuViewHex()
{
	CString cstr, s1, cs;
	//char buf[1024];
	//char* sp = buf;			// buf의 첫번째 위치를 가리키고 있음
	
	CMemo1.GetWindowTextA(cstr);

	// char* str = cstr.GetBuffer();
	// for (int i = 0; *(str + i); i++)
	for (int i = 0; i < strlen(cstr); i++)	// for (int i = 0; *(str + i); i++)
	{
		//// char 배열 및 포인터를 이용한 경우
		//sprintf(sp, "%02X ", *(str + i));
		//while (*sp)	sp++;					// sp위치 증가 -> buf의 다음 공간을 가리킴

		// Cstring class를 이용한 경우
		s1.Format("%02X ", (unsigned)cstr[i]);
		if (i % 16 == 0)	cs += "\r\n";
		cs += s1;
	}
	//CMemo2.SetWindowTextA(buf);
	CMemo2.SetWindowTextA(cs);
}


void CMFCMemo4Dlg::OnMnuFileOpen()
{
	OPENFILENAME ofn;
	char fname[512];
	HWND hwnd = m_hWnd;
	HANDLE hd;
	FILE* fp;

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
		while(fgets(buf, 512, fp) != NULL)
		{
			cstr += buf;
		}
		CMemo1.SetWindowTextA(cstr);
	}

}


void CMFCMemo4Dlg::OnSize(UINT nType, int cx, int cy)
{
	CDialogEx::OnSize(nType, cx, cy);

	// TODO: 여기에 메시지 처리기 코드를 추가합니다.
	if ((GetDlgItem(IDC_TB_MEMO1) != NULL) && (GetDlgItem(IDC_TB_MEMO2) != NULL))
	{
		CMemo1.SetWindowPos(NULL, 5, 5, cx / 2, cy / 2, 0);  // x, y : origin / cx, cy : size
		CMemo2.SetWindowPos(NULL, 5, cy / 2 + 5, cx / 2, cy / 2 -10, 0);
	}
	
}


void CMFCMemo4Dlg::OnActivate(UINT nState, CWnd* pWndOther, BOOL bMinimized)
{
	CDialogEx::OnActivate(nState, pWndOther, bMinimized);

	// TODO: 여기에 메시지 처리기 코드를 추가합니다.
	CRect r;		// client 영역을 담기 위한 구조체
//	GetWindowRect(&r);		// 타이틀바를 포함하여 사각형의 너비,높이를 가져옴
	GetClientRect(&r);
	OnSize(0, r.Width(), r.Height());
}


void CMFCMemo4Dlg::OnClickedButton2()
{
	// TODO: 여기에 컨트롤 알림 처리기 코드를 추가합니다.
	//MessageBox("메시지 박스 테스트중입니다.\n줄바꿈이 먹을까요?");
	/*CDlgTest dlg;
	dlg.DoModal();*/

	CDlgTest* dlgg = new CDlgTest();
	dlgg->DoModal();
	delete dlgg;
}
